using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    interface IMessageLogger 
    {
        void Log(string message);
    }
}
