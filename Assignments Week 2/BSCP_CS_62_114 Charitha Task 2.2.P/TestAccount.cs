
// BSCP|CS|62|114   Charitha Pieris

using System;

class TestAccount
{
    static void Main(string[] args)
    {
        Account myAccount = new Account("Charitha Pieris", 2000.00m);

        Console.WriteLine();
        
        Console.WriteLine($"Welcome, {myAccount.Name}!");  Console.WriteLine();

        myAccount.Print();
        myAccount.Deposit(500.00m);
        myAccount.Withdraw(200.00m);

        Console.WriteLine();

        myAccount.Print();
    }
}

