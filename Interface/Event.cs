namespace interfaceevents
{
using System;

public interface square
{
    event EventHandler Draw;
}
public interface rectangle
{
    event EventHandler Draw;
}
public class Shape : square, rectangle
{
    event EventHandler DrawEvent1;
    event EventHandler DrawEvent2;
    object objectLock = new Object();
    event EventHandler square.Draw
    {
        add
        {
            lock (objectLock)
            {
                DrawEvent1 += value;
            }
        }
        remove
        {
            lock (objectLock)
            {
                DrawEvent1 -= value;
            }
        }
    }
    event EventHandler rectangle.Draw
    {
        add
        {
            DrawEvent2 += value;
        }
        remove
        {
            DrawEvent2 -= value;

        }

    }
    public void Draw()
    {
        EventHandler handler = DrawEvent1;
        if (handler != null)
            {
                handler(this, new EventArgs());
            }
        Console.WriteLine("Drawing a shape.");
        handler = DrawEvent2;
        if (handler != null)
            {
                handler(this, new EventArgs());
            }
    }
}
public class classA
{
    // References the shape object as an square
    public classA(Shape shape)
    {
        square d = (square)shape;
        d.Draw += new EventHandler(d_Draw);
    }

    void d_Draw(object sender, EventArgs e)
    {
        Console.WriteLine("ClassA receives the square event.");
    }
}
public class classB
{
    public classB(Shape shape)
    {
        rectangle d = (rectangle)shape;
        d.Draw += new EventHandler(d_Draw);
    }

    void d_Draw(object sender, EventArgs e)
    {
        Console.WriteLine("ClassB receives the rectangle event.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        classA sub = new classA(shape);
        classB sub2 = new classB(shape);
        shape.Draw();
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}
}
/*
ClassA receives the Square event.
Drawing a shape.
ClassB receives the Rectangle event.
Press any key to exit.
