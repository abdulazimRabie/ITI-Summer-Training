using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChildEngine : ParentEngine
    {
        public override void Engine() {
            Console.WriteLine("Child Engine");
        }

    }
}
