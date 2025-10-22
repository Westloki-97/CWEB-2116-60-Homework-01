using System;

/// <summary>
/// CWEB 2116-60 Application Design I - Homework 01
/// Implements: output statements, comments, variables, constants, data types,
/// typecasting, if-else, and switch.
/// </summary>
namespace Homework01
{
    internal class Program
    {
        /// <summary>
        /// Entry point for the console application.
        /// </summary>
        static void Main(string[] args)
        {
            // -----------------------------
            // Task 1: Output Statements
            // -----------------------------
            // Single-line comment: prints your name and favorite color.
            Console.WriteLine("=== Task 1: Output Statements ===");
            Console.WriteLine("Your name: William Schneider");
            Console.WriteLine("Your favorite color: Blue");
            Console.WriteLine();

            // -----------------------------
            // Task 2: Comments
            // -----------------------------
            /*
               Multi-line comment:
               Below we demonstrate three types of comments:
               1) Single-line: begins with // and continues to end of line.
               2) Multi-line: wrapped with /* ... *\/ across multiple lines.
               3) Documentation (XML) comments: /// placed before types/members for tooling.
            */
            Console.WriteLine("=== Task 2: Comments ===");
            Console.WriteLine("Comments demonstrated in code: single-line, multi-line, and XML doc comments.");
            Console.WriteLine();

            // -----------------------------
            // Task 3: Variables and Data Types
            // -----------------------------
            Console.WriteLine("=== Task 3: Variables and Data Types ===");
            string firstName = "Will";                     // string
            long cityPopulation = 429606;                 // long (example: Minneapolis approx, adjust as desired)
            double tempCelsius = 21.5;                    // double
            bool isStudent = true;                        // bool

            Console.WriteLine($"First name (string): {firstName}");
            Console.WriteLine($"City population (long): {cityPopulation}");
            Console.WriteLine($"Temperature in °C (double): {tempCelsius}");
            Console.WriteLine($"Is student? (bool): {isStudent}");
            Console.WriteLine();

            // -----------------------------
            // Task 4: Constants
            // -----------------------------
            Console.WriteLine("=== Task 4: Constants ===");
            const double Pi = 3.14159; // constant Pi
            double radius = 5;         // given
            double area = Pi * radius * radius;
            Console.WriteLine($"Pi (const): {Pi}");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area of circle = π × r^2 = {area}");
            Console.WriteLine();

            // -----------------------------
            // Task 5: Typecasting and if-else
            // -----------------------------
            Console.WriteLine("=== Task 5: Typecasting and if-else ===");
            Console.Write("Enter your name: ");
            string? nameInput = Console.ReadLine();

            Console.Write("Enter your age: ");
            string? ageInput = Console.ReadLine();

            // Safely parse with TryParse; if invalid, default to -1
            int age = -1;
            if (!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid age input. Using -1.");
            }

            // Typecasting example (int -> string) via interpolation already shown; 
            // we can also cast explicitly if needed, but not necessary here.

            if (age >= 18)
            {
                Console.WriteLine($"{nameInput}, you are eligible to vote.");
            }
            else if (age >= 0)
            {
                Console.WriteLine($"{nameInput}, you are not eligible to vote.");
            }
            else
            {
                Console.WriteLine("Could not determine voting eligibility due to invalid age.");
            }
            Console.WriteLine();

            // -----------------------------
            // Task 6: Switch Statement (Calculator)
            // -----------------------------
            Console.WriteLine("=== Task 6: Switch Statement (Calculator) ===");

            // Helper to read a double with retry once
            double ReadDouble(string prompt)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();
                if (!double.TryParse(s, out double val))
                {
                    Console.WriteLine("Invalid number. Please try once more.");
                    Console.Write(prompt);
                    s = Console.ReadLine();
                    if (!double.TryParse(s, out val))
                    {
                        Console.WriteLine("Invalid again; using 0.");
                        val = 0;
                    }
                }
                return val;
            }

            int ReadInt(string prompt)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();
                if (!int.TryParse(s, out int val))
                {
                    Console.WriteLine("Invalid integer. Using 0.");
                    val = 0;
                }
                return val;
            }

            double number1 = ReadDouble("Enter number1: ");
            double number2 = ReadDouble("Enter number2: ");

            Console.WriteLine("Choose operation: 1=Addition, 2=Subtraction, 3=Multiplication, 4=Division");
            int choice = ReadInt("Enter choice number: ");

            double result;
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"Result (Addition): {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"Result (Subtraction): {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"Result (Multiplication): {result}");
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero is undefined.");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Result (Division): {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("=== End of Program ===");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
