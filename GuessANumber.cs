using System;

namespace GuessANumbGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            while (true)
            {
                Console.Write("Guess a number (1-100): ");
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int PlayerNumber);
                if (isValid)
                {
                    if (PlayerNumber== computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (PlayerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
            }
        }
    }
}
