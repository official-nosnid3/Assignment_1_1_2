namespace Assignment_1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a simple console application and declare basic datatypes 
             * like int, float, decimal, double and print their min and max values. */

            int intValue = 0;
            float floatValue = 0.0f;
            double doubleValue = 0.0;
            decimal decimalValue = 0.0m;

            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");
        }

    }
}
