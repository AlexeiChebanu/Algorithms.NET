using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Algorithms;

internal class Power
{
    public static double MyPow(double x, int n)
    {
        if (n < 0) { x = 1 / x; }
        return RecPow(x, n);
    }

    private static double RecPow(double x, int n)
    {
        if (n == 0) return 1;
        if (n == 1 || n == -1) return x;
        double res = RecPow(x, n / 2);
        return res * res * (n % 2 == 0 ? 1 : x);
    }
}
