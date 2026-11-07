/*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
Example
0 --- Zero
1 --- One
….
9 --- Nine
*/

using System;

namespace DigitToWordConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a digit between 0 and 9
            Console.Write("Enter a digit (0-9): ");

            // Read the user input
            if (int.TryParse(Console.ReadLine(), out int digit))
            {
                // Use a switch statement to map the digit to its English word representation
                switch (digit)
                {
                    case 0:
                        Console.WriteLine($"{digit} --- Zero");
                        break;
                    case 1:
                        Console.WriteLine($"{digit} --- One");
                        break;
                    case 2:
                        Console.WriteLine($"{digit} --- Two");
                        break;
                    case 3:
                        Console.WriteLine($"{digit} --- Three");
                        break;
                    case 4:
                        Console.WriteLine($"{digit} --- Four");
                        break;
                    case 5:
                        Console.WriteLine($"{digit} --- Five");
                        break;
                    case 6:
                        Console.WriteLine($"{digit} --- Six");
                        break;
                    case 7:
                        Console.WriteLine($"{digit} --- Seven");
                        break;
                    case 8:
                        Console.WriteLine($"{digit} --- Eight");
                        break;
                    case 9:
                        Console.WriteLine($"{digit} --- Nine");
                        break;
                    default:
                        Console.WriteLine("Error: Please enter a single digit between 0 and 9.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer number.");
            }
        }
    }
}
