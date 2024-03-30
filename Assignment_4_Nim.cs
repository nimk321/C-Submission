using System;

public class Circle
{
    private double radius;

    // Constructor to initialize the circle with a given radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    //calculating the area of the circle
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    //calculating the perimeter of the circle
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    // Checking if a given point is inside the circle
    public bool IsPointInsideCircle(double x, double y)
    {
        double distanceFromCenter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distanceFromCenter <= radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numberOfCircles = GetNumberOfCirclesFromUser();

        Circle[] circles = CreateCircles(numberOfCircles);

        PrintCircleInfo(circles);

        CheckPointInCircles(circles);
    }

    // Getting the number of circles from the user
    static int GetNumberOfCirclesFromUser()
    {
        Console.Write("Enter the number of circles to create: ");
        return int.Parse(Console.ReadLine());
    }

    // Creating an array of circles with user-defined radius
    static Circle[] CreateCircles(int numberOfCircles)
    {
        Circle[] circles = new Circle[numberOfCircles];
        for (int i = 0; i < numberOfCircles; i++)
        {
            Console.Write($"Enter the radius for circle {i + 1}: ");
            double radius = double.Parse(Console.ReadLine());
            circles[i] = new Circle(radius);
        }
        return circles;
    }

    // Printing information for each circle
    static void PrintCircleInfo(Circle[] circles)
    {
        Console.WriteLine("\nCircle Information:");
        for (int i = 0; i < circles.Length; i++)
        {
            Console.WriteLine($"Circle {i + 1}:");
            Console.WriteLine($"Area: {circles[i].CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {circles[i].CalculatePerimeter():F2}");
            Console.WriteLine();
        }
    }

    // Method to check if a point is inside each circle and print the result
    static void CheckPointInCircles(Circle[] circles)
    {
        Console.Write("Enter the x coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the y coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        for (int i = 0; i < circles.Length; i++)
        {
            bool isInside = circles[i].IsPointInsideCircle(x, y);
            Console.WriteLine($"Point ({x},{y}) is {(isInside ? "inside" : "outside")} of Circle {i + 1}");
        }
    }
}
