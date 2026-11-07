/*1.Write a program to add all the numbers from x to y?
2.Write a C# program to display a perpendicular isosceles triangle of stars.
	        *
              * *
	    * * *
	  * * * *
	* * * * *
*/
using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXERCISE 7: SELECT PROGRAM ===");
            Console.WriteLine("1. Sum of numbers from x to y");
            Console.WriteLine("2. Perpendicular Isosceles Triangle of Stars");
            Console.Write("Choose an option (1 or 2): ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Exercise 1: Sum all numbers from x to y
                Console.Write("Enter starting number (x): ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter ending number (y): ");
                int y = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = x; i <= y; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of all numbers from {x} to {y} is: {sum}");
            }
            else if (choice == "2")
            {
                // Exercise 2: Perpendicular Isosceles Triangle of Stars
                int numberOfRows = 5;

                Console.WriteLine("\n=== Perpendicular Isosceles Triangle of Stars ===");
                for (int i = 1; i <= numberOfRows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
