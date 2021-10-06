using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP.Infrastructure.Common.Async
{
    public class AsyncSemaphore
    {
        private readonly static Task _taskCompleted = Task.FromResult(true);
        private readonly Queue<TaskCompletionSource<bool>> _taskWaiters = new Queue<TaskCompletionSource<bool>>();
        private int _currentCount;

        public AsyncSemaphore(int initialCount)
        {
            if (initialCount < 0)
                throw new ArgumentOutOfRangeException(nameof(initialCount));

            _currentCount = initialCount;
        }

        public Task WaitAsync()
        {
            lock(_taskWaiters)
            {
                if(_currentCount > 0)
                {
                    --_currentCount;
                    return _taskCompleted;
                }
                else
                {
                    var waiter = new TaskCompletionSource<bool>();
                    _taskWaiters.Enqueue(waiter);

                    return waiter.Task;
                }
            }
        }

        public void Release()
        {
            TaskCompletionSource<bool> toRelease = null;
            
            lock(_taskWaiters)
            {
                if (_taskWaiters.Count > 0)
                    toRelease = _taskWaiters.Dequeue();
                else
                    ++_currentCount;
            }

            if (toRelease != null)
                toRelease.SetResult(true);
        }
    }
}
