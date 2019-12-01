using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample
{

public interface ITransactions
{
    void showTransaction();
    double getamnt();
}
public class Transaction : ITransactions
{
    private string Code;
    private string date;
    private double amnt;
    public Transaction()
    {
        Code = " ";
        date = " ";
        amnt = 0.0;
    }
    public Transaction(string c, string d, double a)
    {
        Code = c;
        date = d;
        amnt = a;
    }
    public double getamnt()
    {
        return amnt;
    }
    public void showTransaction()
    {
        Console.WriteLine("Transaction: {0}", Code);
        Console.WriteLine("Date: {0}", date);
        Console.WriteLine("amnt: {0}", getamnt());
    }

}
class example
{
    static void Main(string[] args)
    {
        Transaction t1 = new Transaction("001", "24/06/2014", 87900.00);
        Transaction t2 = new Transaction("002", "25/06/2014", 51900.00);
        t1.showTransaction();
        t2.showTransaction();
        Console.ReadKey();
    }
}
}
