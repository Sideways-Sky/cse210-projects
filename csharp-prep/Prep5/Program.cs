using System;

class Program
{

    static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName(){
        Console.WriteLine("Please enter your name");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number){
        return number*number;
    }

    static void DisplayResult(string name, int squared){
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }
}