using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.String;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        var chars = s.ToCharArray();
        var result = 0;
        var currValue = 0;
        for (var i = 0; i < chars.Length-1; i++) 
        {
            currValue = RomanNum(chars[i]);
            result += (RomanNum(chars[i + 1]) > currValue ? -1 : 1) * currValue;
        }

        return result + RomanNum(chars[chars.Length - 1]);
    }

    private static int RomanNum(char s)
    {
        switch (s)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        };
        return 0;
    }
}
