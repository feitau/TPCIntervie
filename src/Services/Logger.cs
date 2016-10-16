using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// This class is designed to perform a basic logging function.
    /// In the future, we might want to expand our logging capabilities. 
    /// 
    /// Currently, this class doesn't follow SOLID and would require too much modification to extext. 
    /// It violates the Open Close Principle. 
    /// 
    /// Please refactor this method and provide tests in Services.UnitTests.LoggerTests.LogShould.
    /// 
    /// 
    /// Hint:
    /// 
    /// public class ConsoleLogger : IMessageLogger {}
    /// public class QueueLogger : IMessageLogger {}
    /// </summary>
    /// 
    public class QueueLogger : IMessageLogger
    {
        public void Log(string message)
        {
            // Code to send message to printer
        }
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
