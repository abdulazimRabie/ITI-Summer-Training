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
            Child child = new Child();
            child.SetData("John", 10);
            child.ShowData();
            child.ShowFields();

            Point start = new Point(0, 0);
            Point end = new Point(10, 10);
            Line line = new Line(start, end);
            line.ShowLine();

            Color color = new Color("Blue");
            child.FavoriteColor = color;
            child.ShowFavoriteColor();
        }
    }
}
