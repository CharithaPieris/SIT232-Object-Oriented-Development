// BSCP|CS|62|114   Charitha Pieris

using System;

class TestMyTime
{
    static void Main(string[] args)
    {
        // Creating the new MyTime object

        Console.WriteLine();
        MyTime time = new MyTime(12, 30, 45);

        Console.WriteLine("Initial Time: " + time.ToString()); //Displaying the time

        time.NextSecond();
        Console.WriteLine("Next Second: " + time.ToString());

        time.NextMinute();
        Console.WriteLine("Next Minute: " + time.ToString());

        time.NextHour();
        Console.WriteLine("Next Hour: " + time.ToString());

        time.PreviousSecond();
        Console.WriteLine("Previous Second: " + time.ToString());

        time.PreviousMinute();
        Console.WriteLine("Previous Minute: " + time.ToString());

        time.PreviousHour();
        Console.WriteLine("Previous Hour: " + time.ToString());

        Console.WriteLine("\nSetting invalid time:");

        time.SetTime(25, 70, 90); // Invalid values
        Console.WriteLine("After setting invalid time: " + time.ToString());
        Console.WriteLine();

        // Set valid time components and displaying the time
        time.SetHour(22);
        time.SetMinute(58);
        time.SetSecond(10);
        Console.WriteLine("After setting valid time: " + time.ToString());

        Console.ReadLine();
    }
}
