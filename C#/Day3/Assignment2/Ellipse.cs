using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ellipse : Circle
    {
        public double Radius2 { get; set; }

        public new void Display()
        {
            Console.WriteLine($"Ellipse at position ({X}, {Y}) with radii {Radius} and {Radius2}");
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius2;
        }
    }

}
