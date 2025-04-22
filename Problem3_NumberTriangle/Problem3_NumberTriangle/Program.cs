/*
* Problem of the day: Number Triangle
* Date: April 18, 2025
* Solver: Asail Al Shukaili (wd0008)
*
* Problem Description:
* Print a triangle with a specific pattern after reading the height.
* Each row has a pattern of numbers that are powers of 2, symmetric around the middle.
*/
using System;

namespace Problem3_NumberTriangle
{
    class NumberTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem(3) Solution: Number Triangle\n--------------------------");

            // Read the height of the triangle
            Console.Write("Enter triangle height: ");
            int height = int.Parse(Console.ReadLine());

            // Validate input
            if (height <= 0)
            {
                Console.WriteLine("Height must be a positive integer.");
            }

            Console.WriteLine("\nTriangle output:");

            // Print the triangle
            for (int i = 1; i <= height; i++)
            {
                // Print leading spaces for alignment
                for (int space = 0; space < height - i; space++)
                {
                    Console.Write("  "); // Two spaces for better alignment
                }

                // Print numbers in ascending order (powers of 2)
                int value = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{value,2} ");
                    value *= 2;
                }

                // Print numbers in descending order (powers of 2)
                value /= 2; // Adjust value to start descending
                for (int j = 1; j < i; j++)
                {
                    value /= 2;
                    Console.Write($"{value,2} ");
                }

                Console.WriteLine();
            }
        }
    }
}