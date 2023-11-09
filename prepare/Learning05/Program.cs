using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Square s = new Square(3, "red");

        // double SquareArea = s.GetArea();
        // string SquareColor = s.GetColor();
        // Console.WriteLine($"{SquareArea}, {SquareColor}");
        
        // Circle cir = new Circle(4, "green");

        // double CirlceArea = cir.GetArea();
        // string CircleColor = cir.GetColor();
        // Console.WriteLine($"{CirlceArea}, {CircleColor}");
        
        // Rectangle Rect = new Rectangle(5, 6, "purple");

        // double RectangleArea = Rect.GetArea();
        // string RectangleColor = Rect.GetColor();
        // Console.WriteLine($"{RectangleArea}, {RectangleColor}");

        List<Shape> shapes = new List<Shape>
        {
            new Circle(3, "cyan"),
            new Rectangle(2, 5, "orange"),
            new Square(6, "blue")
        };

        foreach (Shape sh in shapes)
        {
            double Area = sh.GetArea();
            string Color = sh.GetColor();
            Console.WriteLine($"{Area}, {Color}");

        }

    }
}