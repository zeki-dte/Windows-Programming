/*Input a numeric grade and convert to letter grade
		[90 .. 101)		A
		[80 .. 90)		B
		[70 .. 80)		C
		[60 .. 70)		D
		otherwise               F
*/

using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numeric grade
            Console.Write("Enter a numeric grade (0 - 100): ");
            
            // Read input and convert it to a double to handle decimal grades if necessary
            if (double.TryParse(Console.ReadLine(), out double score))
            {
                char letterGrade;

                // Determine the letter grade using conditional (if-else if-else) statements
                if (score >= 90 && score < 101)
                {
                    letterGrade = 'A';
                }
                else if (score >= 80 && score < 90)
                {
                    letterGrade = 'B';
                }
                else if (score >= 70 && score < 80)
                {
                    letterGrade = 'C';
                }
                else if (score >= 60 && score < 70)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }

                // Display the final result
                Console.WriteLine($"Numeric Grade: {score} => Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}

