using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Square : Shape
{
    double _side;
    public Square(string color, double side) :base(color)
    {
        _side = side;
    }

   public override double GetArea()
   {
        return _side * _side;
   }
    
}