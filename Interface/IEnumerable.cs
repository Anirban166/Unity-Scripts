using System;
using System.IO;
using System.Collections;
using System.Linq;
class program
{
    public static void Main(string[] args)
    {
        var t = typeof(IEnumerable);
        var typesIEnum = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => t.IsAssignableFrom(x));
        foreach (var types in typesIEnum)
            {
                Console.WriteLine(types.FullName);
            }
        Console.ReadLine();
    }
}
