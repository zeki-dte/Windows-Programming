/*1.Calculate the sum of the integer numbers between 1 and 10
2.Write a C# program to display a perpendicular isosceles triangle of stars.
	*
	* *
	* * *
	* * * *
	* * * * *
*/

using System;

namespace CombinedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Calculate the sum of numbers from x to y
            Console.WriteLine("=== Part 1: Sum from x to y ===");
            Console.Write("Enter starting number (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number (y): ");
            int y = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of numbers from {x} to {y} is: {sum}\n");

            // Part 2: Display a perpendicular isosceles triangle of stars
            Console.WriteLine("=== Part 2: Perpendicular Isosceles Triangle ===");
            int numberOfRows = 5;

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
