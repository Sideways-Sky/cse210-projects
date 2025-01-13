using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        while (true) {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            if (input == 0) {
                break;
            }
            numbers.Add(input);
        }

        Console.WriteLine("The sum of the numbers is " + numbers.Sum());
        Console.WriteLine("The average of the numbers is " + numbers.Average());
        Console.WriteLine("The maximum of the numbers is " + numbers.Max());
        Console.WriteLine("The minimum of the numbers is " + numbers.Min());
        Console.WriteLine("The smallest positive number is " + numbers.Min(x => x > 0 ? x : int.MaxValue));
        Console.WriteLine("The sorted list is " + string.Join(", ", numbers.OrderBy(x => x)));
    }
}