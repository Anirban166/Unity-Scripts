using System;
using System.Timers;
public class Program
{
    private static System.Timers.Timer Tim;
    public static void Main()
    {
        Tim = new System.Timers.Timer(10);
        Tim.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        Tim.Interval = 1000;
        Tim.Enabled = true;
        Console.WriteLine("Press Any Key to Exit else Elapsed Event will be Raised ");
        Console.ReadLine();
    }
    private static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was Raised {0}", e.SignalTime);
    }
}
