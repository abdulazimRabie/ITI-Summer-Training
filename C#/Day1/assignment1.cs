using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        // Question 1
        static void printHello() {
            Console.WriteLine("Hello World");
        }

        // Question 2
        static int PrintAscii(char letter) {
            return (int)letter;
        }

        // Question 3
        static double PrintUserNumber() {
            string user_input = Console.ReadLine();
            Console.WriteLine(user_input);
            return Convert.ToDouble(user_input);
        }

        // Question 4
        static long addIntegers(int num1, int num2) {
            return num1 + num2;
        }

        // Question 5
        static void printHexaOfNumber()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine(number);
            }
        }

        // Question 6
        static void QuotientRemainder() {
            int num1 = 1;
            int num2 = 1;

            float quotient = (float)num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine(remainder);
            Console.WriteLine(quotient);
        }

        // Question 7
        static void EvenOdd() {
            string user_input = Console.ReadLine();
            bool flag = int.TryParse(user_input, out int number);
            if (flag) {
                if (number % 2 == 0) Console.WriteLine("Even");
                else Console.WriteLine("Odd");
            }
        }

        // Question 8
        static int LargestAmongthree(ref int num1, ref int num2, ref int num3) {
            int largest = num1;
            if (num2>largest) largest = num2;
            if (num3 > largest) largest = num3;

            return largest;
        }

        // Question 9
        static void ShowGrade() {
            string user_input = Console.ReadLine();
            switch (user_input) {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B": 
                    Console.WriteLine("Very Good");
                    break;
                case "C": 
                    Console.WriteLine("Good");
                    break;
                case "D": 
                    Console.WriteLine("Fair");
                    break;
                case "E": 
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        // Question 10
        static long TotalNumberTo100(ref int num) {
            long result = num;
            for (int i = num; i < 100; i++) {
                result += i;
            }
            return result;
        }

        // Question 11
        static void MutiplicatinoTable(ref int num) {
            for (int i = 1; i < 13; i++) {
                Console.WriteLine($" {i} * {num} = {i * num}");
            }
        }

        // Question 12
        static bool isAlpha(char char_input) {
            int a = (int)'A';
            int z = (int)'z';
            int character = (int)char_input;
            if (character >= a && character <= z) { return true; }
            return false;
        }

        static void Main(string[] args)
        {
            string hexa = Convert.ToString(12);
            Console.WriteLine($"hexa {hexa}");
            
            /*printHello();
            int result = PrintAscii('A');
            Console.WriteLine(result);*/
        }
    }
}
