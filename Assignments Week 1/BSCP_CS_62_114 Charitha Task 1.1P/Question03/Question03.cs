// BSCP|CS|62|114 Charitha Pieris


using System;

namespace CodeSnippetProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Snippet 1
            int number = 50;
            if (number == 50)
            {
                Console.WriteLine("Number is 50");
            }

            // Snippet 2
            int anotherNumber = 60;
            if (anotherNumber >= 50 && anotherNumber <= 100)
            {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
            }

            // Snippet 3
            double score = 40;
            if (score > 40)
            {
                Console.WriteLine("You passed the exam!");
            }
            else if (score < 40)
            {
                Console.WriteLine("You failed the exam!");
            }

            // Snippet 4
            int n = 2; // Assuming n is defined
            switch (n)
            {
                case 1:
                    Console.WriteLine("The number is 1");
                    break;
                case 2:
                    Console.WriteLine("The number is 2");
                    break;
                default:
                    Console.WriteLine("The number is not 1 or 2");
                    break;
            }

            // Snippet 5
            switch (n)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }
        }
    }
}
