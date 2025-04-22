/*
* Problem of the day: Triangle with White and Black Balls
* Date: April 16, 2025
* Solver: Asail Al Shukaili (wd0008)
*
* Problem Description:
* Given two integers representing the count of white and black balls,
* return the maximum height of the triangle that can be achieved.
* Each triangle should start with white balls, and each row should have the same color.
* Constraints: 1 <= black, white <= 100
*/
using System;

namespace Makeen2_Problem_Of_Day
{
    class TriangleWithBalls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem(2) Solution: Triangle With Balls \n -----------------------");

            // Read the number of white and black ball
            Console.WriteLine("Enter number of white balls:");
            int white = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of black balls:");
            int black = int.Parse(Console.ReadLine());

            // Calculate the maximum triangle height
            if (white < 1 || black < 1 || white > 100 || black > 100)
            {
                Console.WriteLine("\nError: Input values must be between 1 and 100.");
            }

            int initialWhite = white; // Store initial values for visualization
            int initialBlack = black;
            int height = 0; // Initialize height
            bool[] rowColors = new bool[100]; // To store the color of each row for visualization
            int[] rowSizes = new int[100];    // To store the size of each row for visualization

            // Start with white balls for the first row
            bool useWhite = true;

            // Continue building the triangle until we run out of balls
            while (true)
            {
                // Calculate how many balls are needed for the next row
                int nextRowSize = height + 1;

                // Check if we have enough balls of the current color
                if (useWhite)
                {
                    if (white >= nextRowSize)
                    {
                        white -= nextRowSize;
                        rowColors[height] = true; // true for white
                        rowSizes[height] = nextRowSize;
                        height++;
                    }
                    else
                    {
                        break; // Quit if there are no more balls
                    }
                }
                else
                {
                    if (black >= nextRowSize)
                    {
                        black -= nextRowSize;
                        rowColors[height] = false; // false for black
                        rowSizes[height] = nextRowSize;
                        height++;
                    }
                    else
                    {
                        break; // Quit if there are no more balls
                    }
                }

                // Toggle color for next row
                useWhite = !useWhite;
            }

            Console.WriteLine($"Maximum triangle height: {height}");

            // Visualize the triangle
            Console.WriteLine("\nTriangle Visualization:");
            Console.WriteLine("----------------------");

            for (int i = 0; i < height; i++)
            {
                // Add spaces for alignment to create a pyramid shape
                for (int s = 0; s < height - i - 1; s++)
                {
                    Console.Write(" ");
                }

                // Add the balls for this row
                for (int j = 0; j < rowSizes[i]; j++)
                {
                    if (rowColors[i]) // If white
                    {
                        Console.Write("W ");
                    }
                    else // If black
                    {
                        Console.Write("B ");
                    }
                }
                Console.WriteLine();
            }

            // Display the unused balls
            Console.WriteLine("\nUnused balls:");
            Console.WriteLine($"White: {white} of {initialWhite}");
            Console.WriteLine($"Black: {black} of {initialBlack}");
        }
    }
}