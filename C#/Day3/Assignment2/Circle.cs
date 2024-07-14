using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public virtual double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public virtual double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Circle at position ({X}, {Y}) with radius {Radius}");
        }
    }

}
