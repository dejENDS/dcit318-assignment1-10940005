// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a numerical grade between 0 and 100:");
        int numericalGrade = Convert.ToInt32(Console.ReadLine());

        // Determine the letter grade based on the numerical grade
        char letterGrade;
        if (numericalGrade >= 90)
        {
            letterGrade = 'A';
        }
        else if (numericalGrade >= 80)
        {
            letterGrade = 'B';
        }
        else if (numericalGrade >= 70)
        {
            letterGrade = 'C';
        }
        else if (numericalGrade >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        Console.WriteLine($"Corresponding letter grade: {letterGrade}");
    }
}

