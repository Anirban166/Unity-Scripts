using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {
        var stopwatch = Stopwatch.StartNew();
        Thread.Sleep(500);
        stopwatch.Stop();
        Console.WriteLine("Elapsed Milliseconds : {0}",stopwatch.ElapsedMilliseconds);
        Console.WriteLine("Elapsed Ticks : {0}", stopwatch.ElapsedTicks);
        Console.WriteLine("Present Date and Time : {0}",DateTime.Now.ToLongTimeString());
        Console.ReadLine();
    }
}
/*
Elapsed Milliseconds : 498
Elapsed Ticks : 1231409
Present Date and Time : 8:36:06 PM
