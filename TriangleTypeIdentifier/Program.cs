// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the lengths of three sides of a triangle
        Console.WriteLine("Enter the length of side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Determine the type of triangle based on the lengths of the sides
        string triangleType;
        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            triangleType = "Isosceles";
        }
        else
        {
            triangleType = "Scalene";
        }

        // Display the type of triangle to the user
        Console.WriteLine($"The triangle is: {triangleType}");
    }
}
