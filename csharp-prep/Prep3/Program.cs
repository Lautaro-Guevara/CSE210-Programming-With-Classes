using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();

        int magicNumber = randomNumber.Next(1, 100);

        int guess;


        do
        {
            Console.WriteLine("What is your guess");
            string response2 = Console.ReadLine();
            guess = int.Parse(response2);
        
        
            if (magicNumber == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        };
        } while (magicNumber != guess);
        
    }
}