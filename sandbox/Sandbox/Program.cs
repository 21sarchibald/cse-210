using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

class Program
{
    class Circle // This is the class.
    {
        private double radius; // Typically you want to keep the attributes list as small as possible.
        public Circle(double radius) // This is the constructor, which allows you to initialize the object the way that you choose.
        {
            // Console.WriteLine("In the constructor");
            this.radius = radius; // In circle, set the radius equal to the radius that is passed into the parameter of the function.
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetDiameter()
        {
            return 2 * radius;
        }

        public double GetCircumference()
        {
            return Math.PI * 2 * radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius) // void means the function does not return anything.
        {
            this.radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Area is: {GetArea()}");
            Console.WriteLine($"Radius is: {GetRadius()}");
            Console.WriteLine($"Diameter is: {GetDiameter()}");
            Console.WriteLine($"Circumference is: {GetCircumference()}");
        }
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Bonjour mes amis");

        int x = 10;

        Circle myCircle = new Circle(x); // Circle is now a data type (just like int or float).
        Circle myCircle2 = new Circle(x + 10);

        myCircle.Display();
        myCircle.SetRadius(x + 100);
        myCircle.Display();
        // myCircle.radius = 1000; This only works if the variable is public. We usually keep it private to keep control of the variable.

        // Console.WriteLine(myCircle.GetArea());
        // Console.WriteLine(myCircle2.GetArea());

        // Console.WriteLine(myCircle.GetCircumference());
        // Console.WriteLine(myCircle.GetDiameter());
        // Console.WriteLine(myCircle2.GetRadius());

    }

}

// Variable - noun/thing - name, age, number
// Function - verb - do something, calculateArea(), receiveOutput()

// Object - also noun/thing -
// Combining variables (attributes) and functions (methods) into one datatype (class)
// Object - instantiation (creation) of class
// Recipe and cake (the code we write is the recipe, when I create a variable of that type, I have a cake

// class creation
// - Name the class, then decide class methods, then create class attributes



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