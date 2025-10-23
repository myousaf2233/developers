// This program calculates a shipping quote based on package weight and dimensions.
// Author: [Your Name]
// Date: [Today's Date]
// Description: Console-based application for Package Express shipping quote.

using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for the package weight
            Console.WriteLine("Please enter the package weight:");
            // Convert the user input from string to decimal for calculations
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight exceeds the limit (greater than 50)
            if (weight > 50)
            {
                // If too heavy, display message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program early
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if total dimensions exceed 50
            if (width + height + length > 50)
            {
                // If too large, display message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program early
            }

            // Calculate the quote:
            // Multiply width * height * length * weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the final quote to the user, formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // Keeps the console window open until user presses a key
            Console.ReadLine();
        }
    }
}
