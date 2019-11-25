using System;

class Program
{
    static void Main()
    {
        Action<int> action1 =(int x) => Console.WriteLine("OUTPUT {0}", x);
        Action<int, int> action2 =(x, y) => Console.WriteLine("OUTPUT {0} and {1}", x, y);
        action1.Invoke(1111);
        action2.Invoke(200, 3000);
        Console.Read();
    }
}
