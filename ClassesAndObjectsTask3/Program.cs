
    Circle steve = new Circle(10);
    Square bob = new Square(10);
    Triangle lily = new Triangle(5, 2, 3, 4);

    Console.WriteLine("Circle's Area " + steve.Area() + " and parameter " + steve.Perimeter());
    Console.WriteLine("Square's Area " + bob.Area() + " and parameter " + bob.Perimeter());
    Console.WriteLine("Triangle's Area " + lily.Area() + " and parameter " + lily.Perimeter());

public interface GShape
{
    double Area();
    double Perimeter();
}

public abstract class Shape : GShape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(double sideLength)
    {
        Side = sideLength;
    }

    public override double Area()
    {
        return Math.Pow(Side, 2);
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}


public class Circle : Shape
{
    public double R { get; set; }

    public Circle(double radius)
    {
        R = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * R;
    }
}

public class Triangle : Shape
{
    public double B { get; set; }
    public double H { get; set; }
    public double S1 { get; set; }
    public double S2 { get; set; }

    public Triangle(double b, double h, double s1, double s2)
    {
        B = b;
        H = h;
        S1 = s1;
        S2 = s2;
    }

    public override double Area()
    {
        return (B * H) / 2;
    }

    public override double Perimeter()
    {
        return B + S1 + S2;
    }
}