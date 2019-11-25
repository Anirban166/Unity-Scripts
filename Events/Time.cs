//Local:
using System;
class Program
{
    static void Main()
    {
        TimeZone zone = TimeZone.CurrentTimeZone;
        DateTime local = zone.ToLocalTime(DateTime.Now);
        Console.WriteLine("The Local Time is : {0}",local);
        Console.ReadLine();
    }
}
//-------------------------
//Universal:
using System;
class Program
{
    static void Main()
    {
        TimeZone zone = TimeZone.CurrentTimeZone;
        DateTime univ = zone.ToUniversalTime(DateTime.Now);
        Console.WriteLine("Universal Time is {0}",univ);
        Console.Read();
    }
}
