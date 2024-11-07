using System.ComponentModel.DataAnnotations;

class Car
{
    private Tire tires; // Must be declared outside of the constructor, otherwise
                        // its scope would only be within the constructor.

    public Car() // Constructor
    {
        tires = new Tire(205, 55, 16); // Sets tire variable
    }

    public void Display()
    {

        tires.Display();
        Console.WriteLine("Car is alive.");
    }
}