using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car : IVehicle, IDrivable
    {
        private int gasoline;

        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }

        // Implicit implementation of IVehicle
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("Cannot drive. No gasoline.");
            }
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            Console.WriteLine($"The car has been refueled by {amount} units.");
            return true;
        }

        // Explicit implementation of IDrivable
        void IDrivable.Move()
        {
            Console.WriteLine("The car is moving.");
        }

        void IDrivable.Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }

        void IDrivable.Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving (IDrivable).");
            }
            else
            {
                Console.WriteLine("Cannot drive (IDrivable). No gasoline.");
            }
        }
    }
}
