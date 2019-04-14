using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Factors
    {
        public static ArrayList Calculate(int number)
        {
            ArrayList primeFacts = new ArrayList();

            for (int i = 2; i < number+1; i++)
            {
                if (number % i == 0)
                {
                    if (Prime.Checker(i))
                    {
                        primeFacts.Add(i);
                    }
                }
            }

            return primeFacts;
        }
    }
}
