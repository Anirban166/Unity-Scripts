using System;
using System.Threading;
public class pgm
{
    public static void Main()
    {
        Thread newThread = new Thread(pgm.work1);
        newThread.Start(20);
        pgm p = new pgm();
        newThread = new Thread(p.work2);
        newThread.Start("Instance");
        Console.ReadLine();
    }
    public static void work1(object data)
    {
        Console.WriteLine("Static Thread Procedure : Data ='{0}'",data);
    }
    public void work2(object data)
    {
        Console.WriteLine("Instance Thread Procedure : Data ='{0}'", data);
    }
}
/*
Static Thread Procedure : Data = '20'
Instance Thread Procedure : Data = 'Instance'
