
// BSCP|CS|62|114   Charitha Pieris


using System;

namespace Task_1_1P
{
  class SwitchStatments
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number (as an integer): ");
      int number=Convert.ToInt32(Console.ReadLine());
    

    switch (number)
    {
        case 1: Console.WriteLine("ONE"); break;
        case 2: Console.WriteLine("TWO"); break;
        case 3: Console.WriteLine("THREE"); break;
        case 4: Console.WriteLine("FOUR"); break;
        case 5: Console.WriteLine("FIVE"); break;
        case 6: Console.WriteLine("SIX"); break;
        case 7: Console.WriteLine("SEVEN"); break;
        case 8: Console.WriteLine("EIGHT"); break;
        case 9: Console.WriteLine("NINE"); break;

        default: Console.WriteLine("Error: you must eenter an integer between 1 and 9"); break;
    }

    Console.ReadLine();
    }
  }

}