using System;
class Program
{
    static void Main()
    {
        try
            {
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
            }
        catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
    }
}
