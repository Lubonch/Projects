/*
 Created By Lucas - lubonch
 2019

 Problem -Have the user enter a number and find all Prime Factors (if there are any) and display them. 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to find prime factors of: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Printer(Factors.Calculate(value), value);

        }

        public static void Printer(ArrayList arrl, int i)
        {
            if (arrl.Count > 0)
            {
                Console.Write("All the prime factor of {0} are: ", i);
                foreach (int num in arrl)
                {
                    Console.Write("{0} ", num);
                }
                Console.ReadKey();
            }
            else
            {
                Console.Write("{0} Doesn't have prime factors.", i);
                Console.ReadKey();
            }

        }
    }
}
