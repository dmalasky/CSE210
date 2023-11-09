public class Shape
{
    private string _color;


    public Shape()
    {

    }
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea() // Virtual says this method can be overwritten by a child class
    {
        return 0;
    }



}