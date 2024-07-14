using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rect : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rect(int x, int y, int width, int height) : base()
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle at position ({X}, {Y}) with width {Width} and height {Height}");
        }

        public int Area()
        {
            return Width * Height;
        }
    }

}
