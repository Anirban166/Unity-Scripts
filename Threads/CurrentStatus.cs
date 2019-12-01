using System;
using System.Threading;

namespace threading
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Current information");
        Thread t = Thread.CurrentThread;
        t.Name = "primarythread";
        Console.WriteLine("Thread Name: {0}", t.Name);
        Console.WriteLine("Thread Status: {0}", t.IsAlive);
        Console.ReadKey();
    }

}
}
/*
Current information
Thread Name: primarythread
Thread Status: True */
