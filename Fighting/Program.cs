using System;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool victory = false;
            bool defeat = false;

            Console.WriteLine("What's your name fellow being?");

            string playerName = "";

            while (playerName == "")
            {

                playerName = Console.ReadLine();

                if (playerName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid Name, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

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
            int foe1HP = 100;

            Console.WriteLine("A new foe is approaching!: " + foe1);

            Console.ReadLine();

            while (!(foe1HP <= 0 || playerHP <= 0 && victory == true || defeat == true))
            {
                Console.WriteLine(foe1 + " Is choosing a number between 1-10...");

                Random generator = new Random();

                int foeNummber1 = generator.Next(1, 10);

                Console.WriteLine(foe1 + " Chose a number!");

                Console.ReadLine();

                int playerGuess1 = 0;

                bool yourValue = false;

                string guess;

                while (!(playerGuess1 > 0 && playerGuess1 < 11))
                {
                    playerGuess1 = 0;

                    Console.WriteLine(playerName + " Is choosing a number between 1-10...");

                    guess = Console.ReadLine();

                    yourValue = true;

                    try
                    {
                        playerGuess1 = int.Parse(guess);
                    }
                    catch
                    {

                    }
                    if (!(playerGuess1 > 0 && playerGuess1 < 11))
                    {
                        yourValue = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid Value, try again");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.WriteLine(playerName + " Chose a number!");
                Console.WriteLine("Press Enter to see results!");

                Console.ReadLine();

                Console.WriteLine(foe1 + "'s number was: " + foeNummber1);

                if (playerGuess1 == foeNummber1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(playerName + " guessed the number!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(playerName + " did not guess the number!");
                    yourValue = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ReadLine();

                Random damageGenerator = new Random();

                int damage1 = damageGenerator.Next(70);

                if (yourValue == true)
                {
                    foe1HP = foe1HP - damage1;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(foe1 + " took " + damage1 + " damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (yourValue == false)
                {
                    playerHP = playerHP - damage1;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(playerName + " took " + damage1 + " damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ReadLine();

                if (foe1HP < 1)
                {
                    victory = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Victory!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                if (playerHP < 1)
                {
                    defeat = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Defeat!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                if (!(victory == true || defeat == true))
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Status:");
                    Console.WriteLine("Name: " + playerName);
                    Console.WriteLine("HP: " + playerHP);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name: " + foe1);
                    Console.WriteLine("HP: " + foe1HP);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadLine();

                    playerGuess1 = 0;

                    yourValue = false;

                    while (!(playerGuess1 > 0 && playerGuess1 < 11))
                    {

                        playerGuess1 = 0;

                        Console.WriteLine(playerName + " Is choosing a number between between 1-10...");

                        guess = Console.ReadLine();

                        yourValue = true;

                        try
                        {
                            playerGuess1 = int.Parse(guess);
                        }
                        catch
                        {

                        }
                        if (!(playerGuess1 > 0 && playerGuess1 < 11))
                        {
                            yourValue = false;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Invalid Value, try again");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine(playerName + " Chose a number!");

                    Console.WriteLine(foe1 + " Is choosing a number 1-10...");

                    foeNummber1 = generator.Next(1, 10);

                    Console.WriteLine(foe1 + " Chose a number!");

                    Console.WriteLine("Press Enter to see results!");

                    Console.ReadLine();

                    Console.WriteLine(foe1 + "'s number was: " + foeNummber1);

                    if (foeNummber1 == playerGuess1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(foe1 + " guessed the number!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(foe1 + " did not guess the number!");
                        yourValue = false;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.ReadLine();

                    damage1 = damageGenerator.Next(70);

                    if (yourValue == true)
                    {
                        playerHP = playerHP - damage1;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(playerName + " took " + damage1 + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (playerHP < 0) playerHP = 0;
                    }

                    if (yourValue == false)
                    {
                        foe1HP = foe1HP - damage1;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(foe1 + " took " + damage1 + " damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (foe1HP < 0) foe1HP = 0;
                    }

                    Console.ReadLine();

                    if (foe1HP < 1)
                    {
                        victory = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Victory!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                    if (playerHP < 1)
                    {
                        defeat = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Defeat!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                    if (!(victory == true || defeat == true))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Status:");
                        Console.WriteLine("Name: " + playerName);
                        Console.WriteLine("HP: " + playerHP);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name: " + foe1);
                        Console.WriteLine("HP: " + foe1HP);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ReadLine();
                    }
                }
            }
        }
    }
}