using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Concurrency;

internal class ThreadOrdering
{

    private static Semaphore _s2;
    private static Semaphore _s3;

    public ThreadOrdering()
    {
        _s2 = new Semaphore(initialCount: 0, maximumCount: 1);
        _s3 = new Semaphore(initialCount: 0, maximumCount: 1);
    }

    public void First(Action printFirst)
    {

        printFirst();
        _s2.Release();
    }

    public void Second(Action printSecond)
    {

        _s2.WaitOne();
        printSecond();
        _s3.Release();
    }

    public void Third(Action printThird)
    {
        _s3.WaitOne();
        printThird();
    }
}
