using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    public void WorkThreadFunction()
    {
        for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
            }
    }
}
class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
        thread.Start();
        Console.Read();
    }
}
/*
Simple Thread
Simple Thread
Simple Thread
Simple Thread
Simple Thread*/
