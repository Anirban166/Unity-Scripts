class TestUnboxing
{
    static void Main()
    {
        int num = 123;
        object obj = num;
        try
            {
                int j = (short)obj;
                System.Console.WriteLine("Unboxing");
            }
        catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing", e.Message);
            }
        System.Console.Read();
    }
}
