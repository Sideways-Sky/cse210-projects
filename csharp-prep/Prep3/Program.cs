using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        Random random = new Random();
        while (play){
            int number = random.Next(1, 101);
            int guess;
            int guesses = 0;
            do {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess == number) {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (guess < number) {
                    Console.WriteLine("Higher!");
                }
                else {
                    Console.WriteLine("Lower!");
                }
            } while (guess != number);
            Console.WriteLine($"You guessed the number in {guesses} guesses.");
            Console.WriteLine("Do you want to play again? (yes/no)");
            play = Console.ReadLine().ToLower() == "yes";
        }
    }
}