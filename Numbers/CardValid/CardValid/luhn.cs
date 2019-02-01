using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardValid
{
    public class luhn
    {
        public static bool Cvalidate(string card)
        {
                StringBuilder ccard = new StringBuilder(card);
                int sum = 0;
                bool multiply = false;

                for (int i = ccard.Length - 1; i >= 0; i--)
                {
                    int n = Convert.ToInt32(ccard[i]);
                    if (multiply)
                    {
                        n *= 2;
                        if (n > 9)
                        {
                            n = (n % 10) + 1;
                        }
                    }
                    sum += n;
                    multiply = !multiply;
                }
                return (sum % 10 == 0);
            
        }
        public static bool inOut(string c)
        {
            bool validator = false;
            if (c.All(char.IsDigit))
            {
                return !validator;
            }
            return validator;
        }
    }
}
