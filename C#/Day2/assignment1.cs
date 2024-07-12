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
        static void printStars(int rows) {
            int starsNumber = 1;
            for (int i = rows; i > 0; i--) {
                for (int star = 0; star < starsNumber; star++) {
                    Console.Write('*');
                }
                starsNumber += 2;
                Console.WriteLine();
            }
        }

        // Question 2
        static void sumSequence() { 
            string input_1 = Console.ReadLine();
            string input_2 = Console.ReadLine();
            if (int.TryParse(input_1, out int num1) 
                && int.TryParse(input_2, out int num2)) {
                long result = 0;
                for (int i = num1; i <= num2; i++) {
                    result += i;
                }
                Console.WriteLine($"Sum : {result}" );
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // Question 3
        static long Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Question 4
        static int CountDuplicate(int[] arr) {
            int duplicate = 0;
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++) {
                if (freq.ContainsKey(arr[i]))
                    freq[arr[i]]++;
                else
                    freq[arr[i]] = 1;

            }

            foreach(KeyValuePair<int, int> node in freq) {
                if (node.Value > 1) duplicate = node.Value; break;

            }

            return duplicate;
        }

        // Question 5
        static int [] MinMax(int[] arr) {
            int min = arr[0], max = arr[0];
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            
            return new int[] { min, max};
        }

        // Question 6
        static int countSeq(int num) {
            if (num == 0) return 0;
            return num + countSeq(num - 1);
        }

        // Question 7

        static int[] getValues() {
            int[] result = new int[10];

            for (int i = 0; i < 10; i++) {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int val)) {
                    result[i] = val;
                }
                else
                {
                    Console.WriteLine("Imvalid input ! Value will be Zero");
                }
            }

            return result;
        }

        static bool isPrime(int num) {
            if (num <= 1) return false;
            if (num <= 3) return true;

            for(int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
        static void showsPimeValues() {
            int[] values = getValues();

            foreach (int value in values) {
                if (isPrime(value)) Console.WriteLine($"{value} is prime");
                else Console.WriteLine($"{value} is not prime");
            }
        }

        static void Main(string[] args)
        {
            // printStars(5);
            // sumSequence();

            int[] arr = { 1, 1, 1, 2 };
            int duplicate = CountDuplicate(arr);
            Console.WriteLine(duplicate);
            int [] minMax = MinMax(arr);
            foreach (int value in minMax) {
                Console.WriteLine(value);
            }

            Console.WriteLine("=======");
            Console.WriteLine(countSeq(5));
        }
    }
}
