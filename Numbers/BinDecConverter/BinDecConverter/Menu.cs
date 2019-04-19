using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinDecConverter
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Choose the conversion you want to do: \n1 - Binary to Decimal. \n2 - Decimal to binary. \n(Pressing any other key will close the program))");
            String option = Console.ReadLine();
            if (option == "1")
            {
                Menu.Bin();
            }
            else if (option == "2")
            {
                Menu.Dec();
            }
        }
        public static void Bin()
        {
            Console.Write("Please insert the binary number you want to convert:");
            String Binary = Console.ReadLine();
            BinDec.Converter(Binary);
        }
        public static void Dec()
        {
            Console.Write("Please insert the Decimal number you want to convert:");
            try
            {
                int Decimal = Convert.ToInt32(Console.ReadLine());
                DecBin.Converter(Decimal);
            }
            catch (Exception)
            {
                Console.WriteLine("Please, insert a valid Decimal value. \nPress any key to try again.");
                Console.ReadKey();
                Dec();
            }
        }
        public static void Again()
        {
            Console.Write("Do you want to convert another number?\n(Y for yes, anything else to close the program):");
            String decision = Console.ReadLine();
            if (decision.ToLower() == "y")
            {
                Show();
            }
        }
    }
}
