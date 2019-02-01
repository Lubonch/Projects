using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibToN
{
    public class Fib
    {
        public static void FibGen(uint numbers)
        {
            uint c1 = 0;
            uint c2 = 1;
            uint fibNum = 1;
            for (short i = 0; i < numbers; i++)
            {
                if (i == numbers-1)
                {
                    Console.Write(fibNum);
                }
                else
                {
                    Console.Write(fibNum + ",");
                }
                fibNum = c1 + c2;
                c1 = c2;
                c2 = fibNum;
            }
        }
    }
}
