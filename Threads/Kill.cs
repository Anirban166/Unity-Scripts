using System;
using System.Threading.Tasks;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        ThreadingClass th = new ThreadingClass();
        Thread thread1 = new Thread(th.DoStuff);
        thread1.Start();
        Console.WriteLine("Press any key to exit!!!");
        Console.ReadKey();
        th.Stop();
        thread1.Join();
    }
}
public class ThreadingClass
{
    private bool flag = false;
    public void DoStuff()
    {
        while (!flag)
            {
                Console.WriteLine(" Thread is Still Working");
                Thread.Sleep(1000);
            }
    }
    public void Stop()
    {
        flag = true;
    }
}
