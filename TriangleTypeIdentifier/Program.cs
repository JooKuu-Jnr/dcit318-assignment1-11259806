using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Welcome to JooKuu's Assignment.");
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        // Get user input for the three sides
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        // Determine the triangle type
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
