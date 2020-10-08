using System;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name fellow being?");

            string playerName;

            playerName = Console.ReadLine();

            int playerHP = 100;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Status:");
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("HP: " + playerHP);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Round1:");
            Console.ForegroundColor = ConsoleColor.White;

            string foe1 = "Big Slug";

            Console.WriteLine("A new foe is approaching!: " + foe1);

            Console.ReadLine();

            Console.WriteLine(foe1 + " Is choosing a number 1-10...");

            Random generator = new Random();

            int foeNummber1 = generator.Next(1, 10);

            Console.WriteLine(foe1 + " Chose a number " + foeNummber1);

            Console.ReadLine();

            int playerGuess1 = 0;

            Console.WriteLine(playerName + " Is choosing a number between 1-10...");

            string guess;

            guess = Console.ReadLine();

            bool yourValue = true;

            try
            {
                playerGuess1 = int.Parse(guess);
            }
            catch
            {

            }

            if (playerGuess1 < foeNummber1 || playerGuess1 > foeNummber1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(playerName + " did not guess the number!");
                yourValue = false;
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (playerGuess1 == foeNummber1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(playerName + " guessed the number!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadLine();
        }
    }
}
