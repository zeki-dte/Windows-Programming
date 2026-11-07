/*1.What are the values of the following expressions?
10/3
5.2/2.0
9 % 3
2.What is the order of the following expression?
X = 2 * 5 / 3+ 3 * 5 + 7
*/

using System;

namespace ExpressionEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 Expressions
            int divResult = 10 / 3;
            double floatDivResult = 5.2 / 2.0;
            int modResult = 9 % 3;

            Console.WriteLine("=== Part 1 Results ===");
            Console.WriteLine($"10 / 3 = {divResult}");
            Console.WriteLine($"5.2 / 2.0 = {floatDivResult}");
            Console.WriteLine($"9 % 3 = {modResult}");

            // Part 2 Expression Order
            int X = 2 * 5 / 3 + 3 * 5 + 7;
            Console.WriteLine("\n=== Part 2 Result ===");
            Console.WriteLine($"X = 2 * 5 / 3 + 3 * 5 + 7 = {X}");
        }
    }
}
