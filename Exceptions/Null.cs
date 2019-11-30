using System;
class Program
{
    static void Main()
    {
        try
            {
                string value = null;
                if (value.Length == 0)
                    {
                        Console.WriteLine(value);
                    }
            }
        catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        Console.Read();
    }
}
