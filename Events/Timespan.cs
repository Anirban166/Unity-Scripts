using System;
class Program
{
    static void Main()
    {
        TimeSpan s1 = new TimeSpan(5, 0, 0);
        TimeSpan s2 = new TimeSpan(2, 0, 0);
        TimeSpan s3 = s1.Add(s2);
        Console.WriteLine(s3);
        Console.Read();
    }
}
