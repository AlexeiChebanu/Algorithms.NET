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
}
