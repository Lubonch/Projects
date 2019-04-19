using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinDecConverter
{
    class DecBin
    {
        public static void Converter(int i)
        {
            int Binary = DivisionbyTwo(i);

            Console.WriteLine("{0}(10) = {1}(2)", i, Binary);
            Console.ReadKey();
            Menu.Again();
        }

        public static int DivisionbyTwo(int i)
        {
            if (i == 0)
                return 0;

            else
                return (i % 2 + 10 * DivisionbyTwo(i / 2));
        }
    }
}
