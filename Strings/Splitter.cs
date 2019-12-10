using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string sentence = "School had 30 Class rooms, 500 Boys, 500 Girls and 25 Teachers";
        string[] digits = Regex.Split(sentence, @"\D+");
        foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                    {
                        Console.Write(value);
                    }
                Console.ReadLine();
            }
    }
}
