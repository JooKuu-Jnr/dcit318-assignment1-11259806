﻿using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to JooKuu's Assignment.");
        Console.WriteLine("Enter a numerical grade between 0 and 100:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number between 0 and 100.");
        }
    }
}
