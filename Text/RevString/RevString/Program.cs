using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert string");
            String InString = Console.ReadLine();

            Console.WriteLine("The string´{0}´ inverted is: {1}", InString, StringInverter.Run(InString));
            Console.ReadKey();
        }
    }
}
