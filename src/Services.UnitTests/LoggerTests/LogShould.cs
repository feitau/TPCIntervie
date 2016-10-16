using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Services.UnitTests.LoggerTests
{
    public class LogShould
    {
        [Fact]
        public void TestConsoleLogger()
        {
            (new ConsoleLogger()).Log("Testing 123");         
        }

        [Fact]
        public void TestQueueLogger()
        {
            (new QueueLogger()).Log("Testing 123");
        }
    }
}
