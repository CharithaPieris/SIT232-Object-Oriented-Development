// BSCP|CS|62|114   Charitha Pieris

using System;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(30); // Assuming fuel efficiency is 30 mpg

            Console.WriteLine();

            myCar.PrintFuelCost();

            myCar.AddFuel(20); // Adding 20 litres of fuel
            Console.WriteLine($"Fuel in tank: {myCar.GetFuel():F2} litres");

            myCar.Drive(150); // Driving 150 miles
            Console.WriteLine($"Total miles driven: {myCar.GetTotalMiles():F2} miles");
        }
    }
}
