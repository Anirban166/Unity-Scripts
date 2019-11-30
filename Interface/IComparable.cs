using System;
class Fraction : IComparable
{
    int z, n;

    public Fraction(int z, int n)
    {
        this.z = z;
        this.n = n;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.z * b.n + a.n * b.z, a.n * b.n);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.z * b.z, a.n * b.n);
    }

    public int CompareTo(object obj)
    {
        Fraction f = (Fraction)obj;
        if ((float)z / n < (float)f.z / f.n)
            return -1;
        else if ((float)z / n > (float)f.z / f.n)
            return 1;
        else return 0;
    }

    public override string ToString()
    {
        return z + "/" + n;
    }
}

class Test
{

    static void Main(string[] arg)
    {
        Fraction[] a =
        {
            new Fraction(5,2),
            new Fraction(29,6),
            new Fraction(4,5),
            new Fraction(10,8),
            new Fraction(34,7)
        };
        Array.Sort(a);
        Console.WriteLine("Implementing the IComparable Interface in Displaying Fractions : ");
        foreach (Fraction f in a) Console.WriteLine(f + " ");
        Console.WriteLine();
        Console.ReadLine();
    }

}
