namespace Assignment_1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 1.1.2
             * Create a simple console application and declare basic datatypes 
             * like int, float, decimal, double and print their min and max values. */

            int intValue = 0;
            float floatValue = 0.0f;
            double doubleValue = 0.0;
            decimal decimalValue = 0.0m;

            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            /* Assignment 1.1.3
             * Write a C# Sharp program that asks the user for two numbers and then prints them. */

            Console.WriteLine("\n\nInput a number:");
            double numberOne = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Input a second number:");
            double numberTwo = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine($"\nYou have provided the numbers {numberOne} and {numberTwo}.");

            /* Assignemnt 1.1.4 
             * Write a C# Sharp program that divides those numbers and prints the result. */

            double result = numberOne / numberTwo;

            Console.WriteLine($"If you divide {numberOne} by {numberTwo} you would get {result}.");
        }

    }
}
