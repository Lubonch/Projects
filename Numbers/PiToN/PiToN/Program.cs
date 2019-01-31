/*
 Created By Lucas - lubonch
 2019

 Problem -Enter a number and have the program generate PI up to that many decimal places. 
          Keep a limit to how far the program will go. 
 */
using System;
using System.Linq;

namespace PiToN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Pi.PiGen(InputValidator()));
            Console.ReadKey();
        }

        public static int InputValidator()
        {
            string value = string.Empty;
            bool isInvalid = true;
            do
            {
                Console.WriteLine("Enter the number of digit of Pi that you want(This only accept values between 1 - 200):");
                value = Console.ReadLine();
                if (value.All(char.IsDigit) && Convert.ToInt32(value) >= 1 && Convert.ToInt32(value) <= 200)
                {
                    isInvalid = false;
                }
                else
                {
                    Console.WriteLine("The input data is invalid, please enter a valid value.");
                }
            } while (isInvalid);
            return Convert.ToInt32(value);
        }
    }
}
