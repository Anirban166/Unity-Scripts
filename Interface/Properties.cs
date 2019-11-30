using System;

interface IValue
{
    int Count { get; set; }
    string Name { get; set; }
}

class Image : IValue
{
    public int Count
    {
        get;
        set;
    }

    string _name;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
}

class Article : IValue
{
    public int Count
    {
        get;
        set;
    }

    string _name;

    public string Name
    {
        get { return this._name; }
        set { this._name = value.ToUpper(); }
    }
}

class Program
{
    static void Main()
    {
        IValue value1 = new Image();
        IValue value2 = new Article();
        value1.Count++;
        value2.Count++;
        value1.Name = "Tom";
        value2.Name = "Jerry";
        Console.WriteLine(value1.Name);
        Console.WriteLine(value2.Name);
        Console.ReadLine();
    }
}
