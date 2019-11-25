using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {
        // Create new stopwatch
        Stopwatch stopwatch = new Stopwatch();
        // Begin timing
        stopwatch.Start();
        for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
        // Stop timing
        stopwatch.Stop();
        Console.WriteLine("Time Elapsed : {0}",
                          stopwatch.Elapsed);
        Console.ReadLine();
    }
}
