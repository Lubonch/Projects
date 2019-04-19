using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinDecConverter
{
    class BinDec
    {
        public static void Converter(String Bin)
        {
            if (IsBinary(Bin))
            {
                int index = Bin.Length;
                int DecValue = 0;
                foreach (char c in Bin)
                {
                    index -= 1;
                    int digit = int.Parse(c.ToString());
                    DecValue += digit * ((int)Math.Pow(2,index));
                }
                Console.WriteLine("{0}(2) = {1}(10)", Bin, DecValue);
                Console.ReadKey();
                Menu.Again();
            }
            else
            {
                Console.WriteLine("Please, insert a valid binary value. \nPress any key to try again.");
                Console.ReadKey();
                Menu.Bin();
            }
        }

        private static bool IsBinary(String Bin)
        {
            bool flag = true;

            foreach (char c in Bin)
            {
                int Ch = int.Parse(c.ToString());
                if ( Ch != 0 && Ch != 1 )
                {
                    flag = false;
                }
            }
            return flag;
        }

    }
}
