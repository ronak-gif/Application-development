using System;

class Circle
{
    
    public const double PI = 3.14;

    
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    
    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        
        Console.WriteLine($"Value of PI: {Circle.PI}");

        
        double radius = 5;

        
        double area = Circle.CalculateArea(radius);
        Console.WriteLine($"Area of Circle: {area}");

        
        double perimeter = Circle.CalculatePerimeter(radius);
        Console.WriteLine($"Perimeter of Circle: {perimeter}");

        // Try to modify PI
        // Circle.PI = 3.15;
    }
}