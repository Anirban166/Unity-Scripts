using System;
using System.Threading;
class Example
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sleep for 2 Seconds");
                Thread.Sleep(2000);
            }
        Console.WriteLine("Main thread Exits");
        Console.ReadLine();
    }
}
/*
Sleep for 2 Seconds
Sleep for 2 Seconds
Sleep for 2 Seconds
Sleep for 2 Seconds
Sleep for 2 Seconds
Sleep for 2 Seconds
Main thread Exits */
