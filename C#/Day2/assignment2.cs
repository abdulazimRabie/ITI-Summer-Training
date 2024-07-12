using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        // Question 1
        static void convert(int num) {
            Console.WriteLine($"{num}");
        }
        static void convert(double num) {
            Console.WriteLine($"{num}");
        }
        static void convert(float num) {
            Console.WriteLine($"{num}");
        }

        // Question 2 :> you will find them in fiels
        // Question 3 :> you will find them in fiels

        // Question 4
        static long fibonacci(int index) { 
            if (index == 0) return 0;
            if (index == 1) return 1;

            return fibonacci(index - 1) + fibonacci(index - 2);
        }

        // Question 5
        static int sumDigit(string num) {

            if (int.TryParse(num, out int number)) {
                int result = 0;
                while (number != 0) {
                    int remainder = number % 10;
                    number /= 10;
                    result += remainder;
                }
                return result;
            }

            return 0;
        } 

        static void Main(string[] args)
        {

            Car car = new Car(0);

            string user_input = Console.ReadLine();
            if (int.TryParse(user_input, out int newgasoline)) {
                car.Refule(newgasoline);
            }

            car.Drive();


            Console.WriteLine($"{sumDigit("1234")}"); // 10
        }
    }
}
