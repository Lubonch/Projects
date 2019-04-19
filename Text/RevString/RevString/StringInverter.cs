using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevString
{
    class StringInverter
    {
        public static String Run(String InvStr)
        {
            String Str = "";
            foreach (Char c in InvStr)
            {
                Str = c + Str;
            }
            return Str;
        }
    }
}
