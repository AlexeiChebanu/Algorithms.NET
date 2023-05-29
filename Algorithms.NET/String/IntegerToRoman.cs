using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.String
{
    internal class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var DivisionBy10 = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            var DivisionBy100 = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var DivisionBy1000 = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var DivisionBy10000 = new string[] { "", "M", "MM", "MMM" };

            return DivisionBy10000[num / 1000] + DivisionBy1000[(num % 1000) / 100] + DivisionBy100[(num % 100) / 10] + DivisionBy10[num % 10];
        }
    }
}
