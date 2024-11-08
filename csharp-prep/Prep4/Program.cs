using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <double> numberList = new List<double>();
        double number;
        double total = 0;
        double highestValue = 0;

        do
        {
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());
            if (number != 0) 
            {
                numberList.Add(number);
            }
        }
        while (number != 0);

        foreach (double value in numberList)
        {
            if (value > highestValue)
            {
                highestValue = value;
            }
            total += value;
        
        }
        double average = total/numberList.Count;

        Console.WriteLine($"The sum is: {total}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {highestValue}");
    }
}