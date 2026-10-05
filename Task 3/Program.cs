using System;

class Program
{
    static void Main()
    {
        // Declare and initialize different data types

        byte byteValue = 100;
        short shortValue = 20000;
        int intValue = 42;
        long longValue = 1234567890L;

        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;

        char charValue = 'A';
        bool boolValue = true;

        // Convert integer 42 to string
        string integerToString = intValue.ToString();

        // Convert string "3.14" to double
        string numberString = "3.14";
        double stringToDouble = Convert.ToDouble(numberString);

        // Print all variables

        Console.WriteLine("===== Data Types =====");

        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine("\n===== Type Conversion =====");

        Console.WriteLine($"Integer 42 converted to string: {integerToString}");
        Console.WriteLine($"String 3.14 converted to double: {stringToDouble}");
    }
}