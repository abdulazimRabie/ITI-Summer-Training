using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
 
    // Line contains ponits (composition)
    public class Line
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public void ShowLine()
        {
            Console.WriteLine($"Line starts at ({Start.X}, {Start.Y}) and ends at ({End.X}, {End.Y})");
        }
    }
}
