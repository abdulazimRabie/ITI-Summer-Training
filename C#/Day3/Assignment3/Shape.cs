using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        public virtual void Display()
        {
            Console.WriteLine($"Shape at position ({X}, {Y})");
        }
    }

}
