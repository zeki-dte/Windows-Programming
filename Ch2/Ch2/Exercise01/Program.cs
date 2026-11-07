/* Identify the correct identifiers
int Class=2;
	int 2pac = 6;
	int _2pac;
	string greeting = "Hello";
	int numberOfClients= 100;
	int new;
*/

using System;

namespace IdentifierExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# (Identifiers) ===");

            int _2pac = 6; 

            
            string greeting = "Hello"; 

            
            int numberOfClients = 100; 

            
            Console.WriteLine($"_2pac: {_2pac}");
            Console.WriteLine($"greeting: {greeting}");
            Console.WriteLine($"numberOfClients: {numberOfClients}");
        }
    }
}
