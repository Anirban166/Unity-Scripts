using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] a = new int[3];
        a[0] = 1;
        a[1] = 2;
        a[2] = 3;
        Display(a);
        List<int> list = new List<int>();
        list.Add(5);
        list.Add(7);
        list.Add(9);
        Display(list);
        Console.ReadLine();
    }

    static void Display(IList<int> list)
    {
        Console.WriteLine("Count: {0}", list.Count);
        foreach (int num in list)
            {
                Console.WriteLine(num);
            }
    }
}
