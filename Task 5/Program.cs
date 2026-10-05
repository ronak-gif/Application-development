using System;

class Program
{
    static void Main()
    {
        
        DateTime birthDate = new DateTime(2006, 1, 15);

        
        DateTime currentDate = DateTime.Now;

        
        TimeSpan ageDifference = currentDate - birthDate;

        
        int age = (int)(ageDifference.TotalDays / 365.25);

        
        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");

        
        Console.WriteLine($"Current Date and Time: {currentDate}");


        Console.WriteLine($"Age: {age} years");

        
        DateTime dateAfter10Days = birthDate.AddDays(10);

        
        Console.WriteLine($"Birthdate + 10 days: {dateAfter10Days:yyyy-MM-dd}");
    }
}