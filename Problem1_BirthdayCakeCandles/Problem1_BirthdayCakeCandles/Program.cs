/*
* Problem of the day: Birthday Cake Candles
* Date: April 14, 2025
* Solver: Asail Alshukaili (wd0008)
*
* Problem Description:
* Given an array of candle heights, count how many candles are the tallest.
* For example, if candles = [4,1,4,3], the tallest candles are 4 units high, 
* and there are 2 candles with this height.
*/
using System;
using System.Linq;

namespace Problem1_BirthdayCakeCandles
{
    class BirthdayCakeCandles
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem(1) Solution: Birthday Cake Candles \n ______________________________");

            // Read input line containing space-separated integers
            Console.WriteLine("Enter candle heights (space-separated):");
            string input = Console.ReadLine();

            // Parse the input string into an array of integers
            int[] candles = input.Split(' ').Select(int.Parse).ToArray();

            // If the array is empty, return 0
            if (candles.Length == 0)
            {
                Console.WriteLine("Number of tallest candles: 0");
                return;
            }

            // Find the maximum height from the array
            int maxHeight = candles[0];
            foreach (int height in candles)
            {
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
            }

            // Count how many candles have the maximum height
            int count = 0;
            foreach (int height in candles)
            {
                if (height == maxHeight)
                {
                    count++;
                }
            }

            // Display the result
            Console.WriteLine($"Number of tallest candles: {count} which is {maxHeight}");
        }
    }
}