using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace differnce
{
class arrayoutofindex
{
    public void calculatedifference()
    {
        int difference=0;
        int [] number= new int[5] {1,2,3,4,5};
        try
            {
                for (int init =1; init <=5; init++)
                    {
                        difference= difference -  number[init];
                    }
                Console.WriteLine("The difference of the array is:" + difference);
            }
        catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
    }
}
class classmain
{
    static void Main(string [] args)
    {
        arrayoutofindex obj = new arrayoutofindex();
        obj.calculatedifference();
        Console.ReadLine();
    }
}
}
