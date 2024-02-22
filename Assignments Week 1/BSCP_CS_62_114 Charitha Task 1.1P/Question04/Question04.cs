// BSCP|CS|62|114   Charitha Pieris

using System;

class Program
{
    static void Main(string[] args)
    {
        int height = 13;
        if (height <= 12)
        {
            Console.WriteLine("Low bridge: ");
            Console.WriteLine("proceed with caution.");
        }
        // Since height is 13, the condition is false, so these lines won't be executed.

        int sum = 21;
        if (sum != 20)
        {
            Console.WriteLine("You win ");
        }
        else
        {
            Console.WriteLine("You lose ");
            Console.WriteLine("the prize.");
        }
        // sum is 21, which is not equal to 20, so "You win" will be printed.

        sum = 7;
        if (sum > 20)
        {
            Console.WriteLine("You win ");
        }
        else
        {
            Console.WriteLine("You lose ");
            Console.WriteLine("the prize.");
        }
        // sum is 7, which is not greater than 20, so "You lose" will be printed.

        // Final output:
        // You win
        // You lose
        // the prize.
        // You lose
        // the prize.
    }
}
