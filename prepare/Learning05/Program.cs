using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 3);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("yellow", 1, 2);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
    }
}