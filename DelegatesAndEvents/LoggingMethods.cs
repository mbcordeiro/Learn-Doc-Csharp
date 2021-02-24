using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class LoggingMethods
    {
        public static void LogToConsole(string message)
        {
            Console.Error.WriteLine(message);
        }
    }
}
