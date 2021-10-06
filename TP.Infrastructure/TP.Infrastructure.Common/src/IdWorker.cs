using System;

namespace TP.Infrastructure.Common
{
    /// <summary>
    /// From: https://github.com/twitter/snowflake
    /// twittter的snowflake 移植到Java翻译成Net:
    /// (a) id构成: 42位的时间前缀 + 5位的机器标识 + 5位数据中心标识 + 12位的sequence避免并发的数字(12位不够用时强制得到新的时间前缀)
    /// </summary>
    public class IdWorker
    {
        private readonly static IdWorker idWorker = new IdWorker();

        private long workerId;
        private long datacenterId;
        private long sequence = 0L; // 0，并发控制

        private long twepoch = 1505865600000L; //2017-09-20

        private static long workerIdBits = 5L; // 机器标识位数
        private static long datacenterIdBits = 5L; //数据中心位数
        private long maxWorkerId = -1L ^ (-1L << (int)workerIdBits); // 机器ID最大值
        private long maxDatacenterId = -1L ^ (-1L << (int)datacenterIdBits); // 数据ID最大值
        private static long sequenceBits = 12L; // 毫秒内自增位

        private long workerIdShift = sequenceBits;  // 机器ID偏左移10位
        private long datacenterIdShift = sequenceBits + workerIdBits; // 数据ID偏左移20位
        private long timestampLeftShift = sequenceBits + workerIdBits + datacenterIdBits; // 时间毫秒左移22位
        private long sequenceMask = -1L ^ (-1L << (int)sequenceBits); // 序列号ID最大值（4095）

        private long lastTimestamp = -1L;

        private static object syncRoot = new object();

        public IdWorker() : this(0, 0) { }

        public IdWorker(long workerId, long datacenterId)
        {
            // sanity check for workerId
            if (workerId > maxWorkerId || workerId < 0)
            {
                throw new ArgumentException(string.Format("worker Id can't be greater than %d or less than 0", maxWorkerId));
            }
            if (datacenterId > maxDatacenterId || datacenterId < 0)
            {
                throw new ArgumentException(string.Format("datacenter Id can't be greater than %d or less than 0", maxDatacenterId));
            }
            this.workerId = workerId;
            this.datacenterId = datacenterId;
        }

        public static IdWorker Instance
        {
            get { return idWorker; }
        }

        public long NextId()
        {
            lock (syncRoot)
            {
                long timestamp = TimeGen();

                if (timestamp < lastTimestamp)
                {
                    throw new ApplicationException(string.Format("Clock moved backwards.  Refusing to generate id for %d milliseconds", lastTimestamp - timestamp));
                }
                
                if (lastTimestamp == timestamp)
                {
                    // 如果上一个timestamp与新产生的相等，则sequence加一(0-4095循环); 对新的timestamp，sequence从0开始
                    sequence = (sequence + 1) & sequenceMask;
                    if (sequence == 0)
                    {
                        timestamp = TilNextMillis(lastTimestamp); // 重新生成timestamp
                    }
                }
                else
                {
                    sequence = 0L;
                }

                lastTimestamp = timestamp;

                return ((timestamp - twepoch) << (int)timestampLeftShift) | (datacenterId << (int)datacenterIdShift) | (workerId << (int)workerIdShift) | sequence;
            }
        }

        /// <summary>
        /// 等待下一个毫秒的到来, 保证返回的毫秒数在参数lastTimestamp之后
        /// </summary>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        private long TilNextMillis(long lastTimestamp)
        {
            long timestamp = TimeGen();
            while (timestamp <= lastTimestamp)
            {
                timestamp = TimeGen();
            }
            return timestamp;
        }

        /// <summary>
        /// 获得系统当前毫秒数
        /// </summary>
        /// <returns></returns>
        private long TimeGen()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }
    }
}
