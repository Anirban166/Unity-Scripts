using System;
using System.Threading;
class ThreadPoolDemo
{
    public void task1(object obj)
    {
        for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
    }
    public void task2(object obj)
    {
        for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
    }

    static void Main()
    {
        ThreadPoolDemo tpd = new ThreadPoolDemo();
        for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
            }
        Console.Read();
    }
}
/*
Task 1 is being executed
Task 1 is being executed
Task 1 is being executed
Task 1 is being executed
Task 1 is being executed
Task 1 is being executed
Task 2 is being executed
Task 2 is being executed
Task 2 is being executed
Task 2 is being executed
Task 2 is being executed
Task 2 is being executed*/
