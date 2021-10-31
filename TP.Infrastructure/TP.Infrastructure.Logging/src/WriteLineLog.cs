using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Logging;

namespace TP.Infrastructure.Logging.src
{
    public class WriteLineLog
    {
        public static void Debug(object message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
