/*
 Created By Lucas - lubonch
 2019

 Problem -Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Fib.FibGen(InputValidator());
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static uint InputValidator()
        {
            string value = string.Empty;
            bool isInvalid = true;
            do
            {
                Console.WriteLine("Enter the lenght you want for the Fibonacci sequence:");
                value = Console.ReadLine();
                if (value.All(char.IsDigit))
                {
                    isInvalid = false;
                }
                else
                {
                    Console.WriteLine("The input data is invalid, please enter a valid value.");
                }
            } while (isInvalid);
            return Convert.ToUInt32(value);
        }
    }
}
