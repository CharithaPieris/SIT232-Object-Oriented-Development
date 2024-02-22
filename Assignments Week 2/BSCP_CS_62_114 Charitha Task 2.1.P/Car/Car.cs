// BSCP|CS|62|114   Charitha Pieris

using System;

namespace CarConsoleApp
{
    class Car
    {
        private const double FuelCostPerLitre = 1.385;
        private double fuelEfficiency; // miles per gallon (mpg)
        private double fuelInTank; // in litres
        private double totalMilesDriven; // in miles

        public Car(double fuelEfficiency)   // Constructor for the class "Car"
        {
            this.fuelEfficiency = fuelEfficiency;
            fuelInTank = 0;
            totalMilesDriven = 0;
        }

        public double GetFuel()
        {
            return fuelInTank;
        }

        public double GetTotalMiles()
        {
            return totalMilesDriven;
        }

        public void SetTotalMiles(double miles)
        {
            totalMilesDriven = miles;
        }

        public void PrintFuelCost()
        {
            Console.WriteLine($"Current cost of fuel: ${FuelCostPerLitre} per litre");
        }

        public void AddFuel(double litres)
        {
            fuelInTank += litres;
            double cost = CalcCost(litres);
            Console.WriteLine($"Added {litres:F2} litres of fuel. Cost: ${cost}");
        }

        public double CalcCost(double litres)
        {
            return litres * FuelCostPerLitre; 
        }

        public double ConvertToLitres(double gallons)
        {
            return gallons * 4.546;         // Convert gallons to Leters
        }

        public void Drive(double miles)
        {
            totalMilesDriven += miles;
            double gallonsUsed = miles / fuelEfficiency;
            double litresUsed = ConvertToLitres(gallonsUsed);
            double journeyCost = CalcCost(litresUsed);

            Console.WriteLine();
            Console.WriteLine($"You've driven {miles:F2} miles. Fuel used: {litresUsed} litres. Cost of journey: ${journeyCost:F2}");
        }
    }
}
