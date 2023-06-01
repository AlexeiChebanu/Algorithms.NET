using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Array;

internal class Palidrome
{
    public static bool IsPalindrome(int x)
    {
        var y = x.ToString().ToCharArray();
        System.Array.Reverse(y);
        return x.ToString() == new string(y);
    }

    public static bool IsPalindrome2(int x)
    {
        if (x < 0) return false;
        var x_string = x.ToString();
        for (int i = 0; i < x_string.Length; i++)
        {
            if (x_string[i] != x_string[x_string.Length - 1 - i]) return false;
        }
        return true;
    }
}
