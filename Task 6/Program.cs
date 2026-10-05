using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List<string> containing 3 fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        
        fruits.Add("Orange");


        fruits.Remove("Banana");


        Console.WriteLine("Fruits in the List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }



        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };


        fruitDictionary.Add(4, "Orange");

        
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}