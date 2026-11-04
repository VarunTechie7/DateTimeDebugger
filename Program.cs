
using System;

class Program
{
    static void Main(string[] args)
    {
        // Get current date and time
        DateTime currentDate = DateTime.Now;

        // Store current year
        int currentYear = currentDate.Year;

        // Display results
        Console.WriteLine("Date and Time Application");
        Console.WriteLine("------------------------");

        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Current Year: " + currentYear);

        // Check leap year
        bool isLeapYear = DateTime.IsLeapYear(currentYear);

        Console.WriteLine("Is Leap Year: " + isLeapYear);

        Console.WriteLine("\nProgram executed successfully!");
    }
}
