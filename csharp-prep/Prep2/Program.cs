using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade percentage do you have?");
        int score = int.Parse(Console.ReadLine());
        string letter = "F";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }

        if (score % 10 >= 7 && letter != "A" && letter != "F") {
            Console.WriteLine("+");
            letter = "+"+letter;
        } else if (score % 10 < 3 && letter != "F") {
            Console.WriteLine("-");
            letter = "-"+letter;
        }

        if (score >= 70){
            Console.WriteLine("Congratulations You passed!");
        } 
        else {
            Console.WriteLine("Sorry You failed! You got this next time!");
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}