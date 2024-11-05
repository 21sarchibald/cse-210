using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        int x = 10;
        int y = x++;

        Console.WriteLine($"{y}, {x}");

        int z = ++y;
        Console.WriteLine($"{z}, {y}");
    }

}
// Creating functions/methods

    // static int AddNumbers(int n1, int n2) // You must declare the parameter variable type. Using static means you can use the function without an instance of the object.
    // {
    //     int total = n1 + n2;
    //     int total2 = n1 * n2;
    //     return total; // You can only return one value in C#.
    // }
    // public static void Main(string[] args)
    // {

    //     int total = AddNumbers(20, 30);
    //     Console.WriteLine(total);

    // Do While loops

        // int age;
        // do // The block in the loop will execute at least once. You don't need an entrance strategy in a do while loop.
        // {
        //     Console.Write("Please enter your age: (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }while(age < 0 || age > 125);

    // Lists
            
        // List <string> myColors = new List<string>(); // List <variable type> listName = new List<variableType>();

        // myColors.Add("Red");
        // myColors.Add("Green");
        // myColors.Add("Blue");

        // // For each loops
        // foreach(string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }
        
    // For loops

        // for(int i = 0; i < 10; i++) // (initialize i; conditional; executed with each iteration)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;
        // while(age < 0 || age > 125)
        // {
        //     Console.Write("Please enter your age: (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }

//     }
// }


// Week 1

// class Program
// {

//     // void tells the computer the function doesn't return anything.
//     // static means it can run without having an object associated with it.
//     // public means anyone can use it
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Input your age: ");
//         string userInput = Console.ReadLine();
//         int age = int.Parse(userInput); // Parse turns an integer string into an integer data type.

//         Console.WriteLine($"Your age is: {age}"); // Format output with a $

//         // Console.WriteLine("Hello, World!");
//         // Console.WriteLine("Bonjour Tout le Monde.")

//         int x = 10; // You must give your variable a type, and you must give your parameters a type in functions.
//         if (x > 15)
//         {
//             Console.WriteLine("Hey Bob");
//         }
//         // Console.WriteLine("Please enter your name");
//         // string name = Console.ReadLine();

//         // Console.WriteLine("$Your name is: {name}\n");
//     }
// }

// {
//     static void Main(string[] args)
//     // {
//     //     Console.WriteLine("Hello Sandbox World!");
//     // }
// }