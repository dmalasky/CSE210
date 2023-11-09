public class Circle : Shape
{
    
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;

    }


    public override double GetArea()
    {
        double pi = Math.PI;
        return pi * (_radius *_radius) ;
    }

}