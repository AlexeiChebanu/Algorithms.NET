using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.String
{
    internal class ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length) return s;

            List<StringBuilder> rows = new List<StringBuilder>();

            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new StringBuilder());
            }

            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow].Append(c);

                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }

                currentRow += goingDown ? 1 : -1;

            }

            StringBuilder result = new StringBuilder();

            foreach (StringBuilder row in rows)
            {
                result.Append(row.ToString());
            }

            return result.ToString();
        }

        public string Convert2(string s, int numRows)
        {
            string[] str = new string[numRows];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = "";
            }

            for (int i = 0; i < s.Length;)
            {
                for (int m = 0; m < numRows && i < s.Length; m++)
                {
                    str[m] += s[i++];
                }
                for (int n = numRows - 2; n > 0 && i < s.Length; n--)
                {
                    str[n] += s[i++];
                }

            }

            string result = "";
            foreach (string ss in str)
            {
                result += ss;
            }
            return result;
        }
    }
}
