
// BSCP|CS|62|114   Charitha Pieris

using System;

class Account     // Main class
{
    private decimal _balance;   
    private string _name;   

    public Account(string name, decimal balance)
    {
        _name = name;   // Holds the balance specific to an account
        _balance = balance; //  Holds the account holder's name
    }

    //*************************************************************************************************\\
    // Deposit, Withdraw, and Print that define actions an account can take. Methods of the Account class

    public void Deposit(decimal amount)
    {
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");  // C - To convert the Currency format to USD " $ "     
    }

    public void Withdraw(decimal amount)
    {
            _balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {_balance:C}");
    }

    public void Print()
    {
        Console.WriteLine($"Account Name: {_name}");
        Console.WriteLine($"Balance: {_balance:C}");
    }

    public string Name
    {
        get { return _name; }
    }
}
