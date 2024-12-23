using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Fraction 
{
    private int _top;
    private int _bottom;


    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) 
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        int top = GetTop();
        int bottom = GetBottom();
        return $"{top}/{bottom}";
    }
    public double GetDecimalValue()
    {
        double top = GetTop();
        double bottom = GetBottom();
        return top/bottom;
    }
}