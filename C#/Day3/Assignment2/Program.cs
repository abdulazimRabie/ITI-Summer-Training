using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Circle circle = new Circle { X = 5, Y = 5, Radius = 3 };
        circle.Display();
        Console.WriteLine($"Circle Area: {circle.Area()}");
        Console.WriteLine($"Circle Area (overloaded): {circle.Area(4)}");

        Rect rect = new Rect(10, 10, 4, 6);
        rect.Display();
        Console.WriteLine($"Rectangle Area: {rect.Area()}");

        Ellipse ellipse = new Ellipse { X = 2, Y = 2, Radius = 3, Radius2 = 5 };
        ellipse.Display();
        Console.WriteLine($"Ellipse Area: {ellipse.Area()}");
        }
    }
}
