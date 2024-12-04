using System.Formats.Asn1;

class Shape 
{
    protected string _color;

    public Shape(string color)
    {
        SetColor(color);
    }
    private void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 0;
    }


}