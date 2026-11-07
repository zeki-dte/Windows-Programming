/*A company dealing with marketing wants to keep a data record of its employees. 
Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
*/
using System;

namespace EmployeeRecordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring appropriate variables for an employee record
            string firstName = "Abebe";
            string lastName = "Kebede";
            int age = 28;
            char gender = 'm';
            int employeeNumber = 2756045; // Falls within the range 2756000 to 2756999

            // Displaying the employee details to the console
            Console.WriteLine("=== Employee Record ===");
            Console.WriteLine($"Employee Number: {employeeNumber}");
            Console.WriteLine($"Full Name:       {firstName} {lastName}");
            Console.WriteLine($"Age:             {age}");
            Console.WriteLine($"Gender:          {gender}");
        }
    }
}
