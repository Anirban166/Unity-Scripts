using System;
interface IDumpable
{
    string Name { get; set; }
    void Dump();
}

class Fraction : IDumpable
{
    int z, n;
    string name;

    public Fraction(int z, int n)
    {
        this.z = z;
        this.n = n;
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public void Dump()
    {
        Console.WriteLine("Fraction : " + z + "/" + n);
    }
}

class Person : IDumpable
{
    string name;
    public string address;
    public int phone;

    public Person(string name, string address, int phone)
    {
        this.name = name;
        this.address = address;
        this.phone = phone;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Dump()
    {
        Console.WriteLine("Person Details : {0}, {1}, {2}", name, address, phone);
    }
}

class Test
{

    static void Main(string[] arg)
    {
        IDumpable[] a =
        {
            new Fraction(10,3),
            new Fraction(9,4),
            new Person("Tom", "Japan", 99556677),
            new Person("Jerry", "Japan", 998979899),
        };
        a[0].Name = "f1";
        a[1].Name = "f2";
        foreach (IDumpable obj in a)
            {
                Console.Write(obj.Name + ": ");
                obj.Dump();
            }
        Console.ReadLine();
    }

}
