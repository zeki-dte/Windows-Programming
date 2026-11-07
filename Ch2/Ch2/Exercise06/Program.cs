/*What is the output of the following code? When x=4;
int num=5;
if(num<10)
		Console.WriteLine(“Number is less than 10”);
else
		if(num<5)
			Console.WriteLine(“Number is less than 5”);
		else
			Console.WriteLine(“Number is equal to or greater than 5”);

How do we fix it?
*/

using System;

namespace DanglingElseFix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;

            // Using curly braces {} to explicitly define block scopes and prevent dangling else ambiguity
            if (num < 10)
            {
                Console.WriteLine("Number is less than 10");
            }
            else
            {
                if (num < 5)
                {
                    Console.WriteLine("Number is less than 5");
                }
                else
                {
                    Console.WriteLine("Number is equal to or greater than 5");
                }
            }
        }
    }
}
