using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteMessage += LoggingMethods.LogToConsole;
            var file = new FileLogger("log.txt");
        }
    }
}
