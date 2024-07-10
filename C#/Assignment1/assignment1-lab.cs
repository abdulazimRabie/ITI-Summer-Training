using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        // Question 1
        static void showOddEvenNumber() {
            for (int i = 0; i <= 100; i++) {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} -> Even");
                else
                    Console.WriteLine($"{i} -> Odd");
            }
        }

        // Question 2
        static String ShowGrade() {
            string user_input = Console.ReadLine();
            if (double.TryParse(user_input, out double userDegreee)) {
                if (userDegreee >= 39 && userDegreee <= 100) return "A";
                else if (userDegreee >= 90 && userDegreee <= 92) return "A";
                else if (userDegreee >= 87 && userDegreee <= 89) return "A-";
                else if (userDegreee >= 83 && userDegreee <= 86) return "B+";
                else if (userDegreee >= 80 && userDegreee <= 82) return "B";
                else if (userDegreee >= 77 && userDegreee <= 79) return "B-";
                else if (userDegreee >= 73 && userDegreee <= 76) return "C+";
                else if (userDegreee >= 70 && userDegreee <= 72) return "C";
                else if (userDegreee >= 67 && userDegreee <= 69) return "C-";
                else if (userDegreee >= 63 && userDegreee <= 66) return "D+";
                else if (userDegreee >= 63 && userDegreee <= 66) return "D";
                else if (userDegreee >= 60 && userDegreee <= 62) return "D-";
                else return "F";
            }

            return "Inavlid Input";
        }

        // Question 3
        static void showLargestFromUser() {
            while (true) {
                String input_user = Console.ReadLine();
                int largest = int.MinValue;
                if (int.TryParse(input_user, out int userNumber)) {
                    if (userNumber > largest) {
                        largest = userNumber;
                        Console.WriteLine($"Largest {largest}");
                    }
                }
            }
        }

        // Questino 4
        static bool TryReadDouble(out double result) {
            string input = Console.ReadLine();

            if (double.TryParse(input, out result)) {
                return true;
            }

            return false;
        }
        static bool isStraight() {
            double x1, x2, x3, y1, y2, y3;

            if (
                TryReadDouble(out x1) &&
                TryReadDouble(out y1) &&
                TryReadDouble(out x2) &&
                TryReadDouble(out y2) &&
                TryReadDouble(out x3) &&
                TryReadDouble(out y3)
            ) {
                double slope_1 = (y2 - y1) / (x2 - x1);
                double slope_2 = (y3 - y2) / (x3 - x2);

                if (slope_1 == slope_2) return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HI");
        }
    }
}
