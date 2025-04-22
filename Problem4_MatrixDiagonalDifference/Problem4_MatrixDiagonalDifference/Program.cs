/*
* Problem of the day: Matrix Diagonal Difference
* Date: April 21, 2025
* Solver: Asail Al Shukaili (wd0008)
*
* Problem Description:
* Calculate the absolute difference between the sum of diagonals in a square matrix.
* The matrix must be square (n×n).
*/
using System;

namespace Problem4_MatrixDiagonalDifference
{
    class MatrixDiagonalDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem(4) Solution: Matrix Diagonal Difference\n--------------------------");

            // Read matrix size
            Console.Write("Enter matrix size (n): ");
            int n = int.Parse(Console.ReadLine());

            // Validate input
            if (n <= 0)
            {
                Console.WriteLine("Matrix size must be a positive integer.");
            }

            // Create matrix
            int[,] matrix = new int[n, n];

            // Read matrix elements
            Console.WriteLine($"\nEnter {n}x{n} matrix elements row by row (space-separated):");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Row {i + 1}: ");
                string[] rowElements = Console.ReadLine().Split(' ');

                // Validate number of elements in row
                if (rowElements.Length != n)
                {
                    Console.WriteLine($"Error: Row should contain exactly {n} elements.");
                    return;
                }

                // Parse elements
                for (int j = 0; j < n; j++)
                {
                    if (!int.TryParse(rowElements[j], out matrix[i, j]))
                    {
                        Console.WriteLine("Error: All elements must be integers.");
                        return;
                    }
                }
            }

            // Calculate diagonal sums
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                // Primary diagonal: elements where row index equals column index
                primaryDiagonalSum += matrix[i, i];

                // Secondary diagonal: elements where row index + column index = n - 1
                secondaryDiagonalSum += matrix[i, n - 1 - i];
            }

            // Calculate absolute difference
            int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            // Display the matrix
            Console.WriteLine("\nMatrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            // Display results
            Console.WriteLine($"\nPrimary diagonal sum: {primaryDiagonalSum}");
            Console.WriteLine($"Secondary diagonal sum: {secondaryDiagonalSum}");
            Console.WriteLine($"Absolute difference: {absoluteDifference}");
        }
    }
}