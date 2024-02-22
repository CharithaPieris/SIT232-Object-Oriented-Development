// BSCP|CS|62|114   Charitha Pieris

using System;

namespace employee
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Employee jim = new Employee("Charitha", 36000);

            Console.WriteLine("Employee Name: " + jim.GetName() + "\nCurrent Salary: " + jim.GetSalary() + "\nAfter the Raise: " + jim.GetRaisedSalary() + "\nTax: " + jim.Tax());

            jim.SetName("Kamal");
            jim.SetSalary(40000);
            jim.ApplyRaise();

            //Display the Output and call the functions
            Console.WriteLine();
            Console.WriteLine("Employee Name: " + jim.GetName() + "\nCurrent Salary: " + jim.GetSalary() + "\nAfter the Raise: " + jim.GetRaisedSalary() + "\nTax: " + jim.Tax());
            Console.WriteLine("Salary after Tax : " + jim.GetSalaryAfterTax());

            Console.ReadLine();
        }
    }
}
