using System;
using System.IO;
class ConsoleApplication
{
    const string fileName = "program.dat";
    static void Main()
    {
        Write();
        Console.WriteLine("Using Binary Writer Class the Contents are Written ");
    }
    public static void Write()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
            writer.Write(1.250F);
            writer.Write(@"c:\Temp");
        }
    }
}
