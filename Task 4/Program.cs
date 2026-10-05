using System;

class Program
{
    static void Main()
    {
        
        int[] favoriteNumbers = { 25, 7, 10, 50, 3 };

        Console.WriteLine("Original Array:");

        
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        
        Array.Sort(favoriteNumbers);

        Console.WriteLine("\nAfter Array.Sort():");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("\nAfter Array.Reverse():");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        
        int searchNumber = 10;

        int position = Array.IndexOf(favoriteNumbers, searchNumber);

        Console.WriteLine($"\nPosition of {searchNumber}: {position}");
    }
}
// git commit -m "Complete Task 4 - Arrays and Array Methods"