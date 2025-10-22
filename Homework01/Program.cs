using System;
using System.Globalization;

namespace Homework01
{
    /// <summary>
    /// CWEB 2116-60 Application Design I — HOMEWORK 01
    /// Implements Tasks 1–6 in a single console app.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make numeric parsing consistent (e.g., users typing "." for decimals)
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Line("===== TASK 1: Output Statements =====");
            Task1_OutputStatements();

            Line("\n===== TASK 2: Comments (see code for examples) =====");
            Task2_CommentsDemo();

            Line("\n===== TASK 3: Variables and Data Types =====");
            Task3_VariablesAndDataTypes();

            Line("\n===== TASK 4: Constants (Pi) and Circle Area =====");
            Task4_ConstantsCircleArea();

            Line("\n===== TASK 5: Typecasting and if-else (Voting Eligibility) =====");
            Task5_TypecastingAndIfElse();

            Line("\n===== TASK 6: Switch Statement (Simple Calculator) =====");
            Task6_SwitchCalculator();

            Line("\nAll tasks complete. Press Enter to exit.");
            Console.ReadLine();
        }

        // Utility: write a full line
        static void Line(string s) => Console.WriteLine(s);

        // -----------------------------------------------------------
        // TASK 1: Output Statements
        // -----------------------------------------------------------
        /// <summary>
        /// Prints a name and favorite color using Console.WriteLine().
        /// </summary>
        static void Task1_OutputStatements()
        {
            // Required Output (example)
            Console.WriteLine("Your name: William Schneider");
            Console.WriteLine("Your favorite color: Blue");
        }

        // -----------------------------------------------------------
        // TASK 2: Comments
        // -----------------------------------------------------------
        /// <summary>
        /// Demonstrates single-line, multi-line, and documentation comments.
        /// </summary>
        static void Task2_CommentsDemo()
        {
            // Single-line comment: This explains the next line of code.
            Console.WriteLine("Single-line comment shown above.");

            /* 
               Multi-line comment:
               These comments can span multiple lines and are useful
               for explaining larger sections or temporarily disabling code.
            */
            Console.WriteLine("Multi-line comment shown in the code.");

            /// <remarks>
            /// XML documentation comments (like this) are used to generate
            /// documentation and to provide IntelliSense tooltips. They are
            /// typically placed above declarations (classes/methods).
            /// </remarks>
            Console.WriteLine("XML documentation comment shown above this method.");
        }

        // -----------------------------------------------------------
        // TASK 3: Variables and Data Types
        // -----------------------------------------------------------
        /// <summary>
        /// Declares variables of specified types and prints their values.
        /// </summary>
        static void Task3_VariablesAndDataTypes()
        {
            string firstName = "Alex";
            long cityPopulation = 4981234L;
            double tempCelsius = 21.6;
            bool isStudent = true;

            Console.WriteLine($"First name (string): {firstName}");
            Console.WriteLine($"City population (long): {cityPopulation}");
            Console.WriteLine($"Temperature (double, °C): {tempCelsius}");
            Console.WriteLine($"Is student? (bool): {isStudent}");
        }

        // -----------------------------------------------------------
        // TASK 4: Constants
        // -----------------------------------------------------------
        /// <summary>
        /// Uses a constant for Pi and computes the area of a circle with radius = 5.
        /// </summary>
        static void Task4_ConstantsCircleArea()
        {
            const double Pi = 3.14159; // constant as required
            double radius = 5.0;       // variable as required
            double area = Pi * radius * radius;
            Console.WriteLine($"Pi = {Pi}, radius = {radius}");
            Console.WriteLine($"Area of circle = {area}");
        }

        // -----------------------------------------------------------
        // TASK 5: Typecasting and if-else
        // -----------------------------------------------------------
        /// <summary>
        /// Gets name and age from the user, typecasts age, and prints voting eligibility.
        /// </summary>
        static void Task5_TypecastingAndIfElse()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your age: ");
            string? ageText = Console.ReadLine();

            // Typecast/parse as needed
            if (!int.TryParse(ageText, out int age))
            {
                Console.WriteLine("Invalid age. Please run the task again and enter a whole number.");
                return;
            }

            if (age >= 18)
            {
                Console.WriteLine($"{name}, you are {age} and eligible to vote.");
            }
            else
            {
                Console.WriteLine($"{name}, you are {age} and NOT eligible to vote.");
            }
        }

        // -----------------------------------------------------------
        // TASK 6: Switch Statement
        // -----------------------------------------------------------
        /// <summary>
        /// Gets two numbers and a choice (1–4) from the user, then performs the operation via switch.
        /// 1=Addition, 2=Subtraction, 3=Multiplication, 4=Division.
        /// </summary>
        static void Task6_SwitchCalculator()
        {
            Console.Write("Enter number1: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid number1.");
                return;
            }

            Console.Write("Enter number2: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid number2.");
                return;
            }

            Console.Write("Enter choice (1=Add, 2=Sub, 3=Mul, 4=Div): ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result (Addition): {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Result (Subtraction): {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Result (Multiplication): {a * b}");
                    break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Cannot divide by zero.");
                    else
                        Console.WriteLine($"Result (Division): {a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
