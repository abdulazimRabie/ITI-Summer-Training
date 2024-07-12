using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Vehicle
    {
        public int gasolineAmount = 0;

        public Car(int gasolineAmount) { 
            this.gasolineAmount = gasolineAmount;
        }

        public void Drive()
        {
            Console.WriteLine($"Car is driving. Gasline Amout is {this.gasolineAmount}");
        }

        public void Refule(int gasolineAmount)
        {
            this.gasolineAmount += gasolineAmount;
            Console.WriteLine($" Gasoline Amount now is {this.gasolineAmount}");
        }
    }
}
