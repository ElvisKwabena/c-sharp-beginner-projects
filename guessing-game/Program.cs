// See https://aka.ms/new-console-template for more information

using System;
namespace GuessGame { 
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNum = random.Next(1, 11);

            Console.WriteLine("Hello, Welcome to the Numbers Guessing game!");
            Console.WriteLine("A number between 1 and 10 would be generated");
            Console.WriteLine("If you guess the correct number, you win!");

            Console.WriteLine("Please enter your guess");

            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess==0 || guess > 10)
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }

            while (guess != randomNum)
            {
                 while (guess > randomNum)
                 {
                Console.WriteLine("Kindly try again, your guess was too high.");
                guess=Convert.ToInt32(Console.ReadLine());
                 }

                while (guess < randomNum)
                {
                Console.WriteLine("Kindly try again, your guess was too low");
                guess = Convert.ToInt32(Console.ReadLine());
                }
        }

            while (guess==randomNum)
                {
                Console.WriteLine("Correct!, You guessed right");
                Console.WriteLine("Congratulations, you guessed right");
                break;


                }

                


            }


        }

    }

