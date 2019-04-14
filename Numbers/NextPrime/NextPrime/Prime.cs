using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrime
{
    class Prime
    {
        public static void Displayer()
        {
            int number = 2;
            string cont = "y";

            Console.WriteLine("Prime Number Displayer: ");

            while (cont.ToLower() == "y")
            {
                bool redo;
                do
                {
                    if (IsPrime(number))
                    {
                        Console.WriteLine("{0} ", number);
                        redo = false;
                    }
                    else
                    {
                        number++;
                        redo = true;
                    }

                } while (redo);
                    

                number++;
                Console.Write("Do you want the next prime number?( y = next  Anything else = quit): ");
                cont = Console.ReadLine();
            }
                
        }

        public static bool IsPrime(int num)
        {
            bool Prime = true;

            for (short i = 2; i < num; i++)
            {
                if (num % i == 0)
                    Prime = false;
            }

            return Prime;
        }
    }
}
