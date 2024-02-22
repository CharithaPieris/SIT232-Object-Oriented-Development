
// BSCP|CS|62|114   Charitha Pieris

using System;

namespace GuessingNumber
{
    class Program
    {
        static void Main()
        {
            int user1Number;

            while (true)
            {
                Console.Write("User 1: Enter a number between 1 and 10: ");
                if (int.TryParse(Console.ReadLine(), out user1Number) && user1Number >= 1 && user1Number <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10.");
                }
            }

            Console.WriteLine("User 2: Guess the number set by User 1!");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int user2Guess))
                {
                    if (user2Guess < 1 || user2Guess > 10)
                    {
                        Console.WriteLine("Please enter a number between 1 and 10.");
                    }
                    else if (user2Guess == user1Number)
                    {
                        Console.WriteLine("Congratulations! You have guessed the number!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess. Try again:");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
