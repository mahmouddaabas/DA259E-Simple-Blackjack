using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Logger
    {
        public static Action<string> writeMessage;

        public static void LogMessage(string msg)
        {
            //writeMessage += LogToConsole;
            //writeMessage += LogToFile;
            writeMessage(msg);
        }
    }
}
