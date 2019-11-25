using System;
delegate bool Condition(object obj);
delegate void Action(object obj);
class Counter
{
    int val = 0;

    public event Condition cond;
    public event Action evn;

    public int Value { get { return val; } }

    public void addition(int x)
    {
        val += x;
        Checkpoint();
    }

    public void Clearall()
    {
        val = 0;
        Checkpoint();
    }

    void Checkpoint()
    {
        if (cond != null && evn != null && cond(this)) evn(this);
    }
}
class Test
{
    static int hval = 0;
    static bool CheckpointLimit(object ctr)
    {
        return (((Counter)ctr).Value > 100);
    }
    static void Alarm(object ctr)
    {
        Console.WriteLine("Counter Overflow");
    }
    static void Reset(object ctr)
    {
        hval = ((Counter)ctr).Value;
        Console.WriteLine("hval = " + hval);
        ((Counter)ctr).Clearall();
    }
    public static void Main()
    {
        Counter counter = new Counter();
        counter.cond += new Condition(CheckpointLimit);
        counter.evn += new Action(Alarm);
        counter.evn += new Action(Reset);
        counter.addition(10);
        counter.addition(20);
        counter.addition(30);
        counter.addition(40);
        counter.addition(50);
        Console.Read();
    }
}
