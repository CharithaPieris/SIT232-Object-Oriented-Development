// BSCP|CS|62|114 Charitha Pieris

using System;

class Account
{
    private decimal _balance;
    private string _name;

    public Account(string name, decimal balance)
    {
        this._name = name;
        this._balance = balance;
    }

    // Public property to get the account balance
    public decimal Balance
    {
        get => _balance;
    }

    // Method to deposit money into the account
    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        else
        {
            _balance = _balance + amount;
            return true;
        }
    }

    // Method to withdraw money from the accounts
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount >= _balance)
        {
            return false;
        }
        else
        {
            _balance = _balance - amount;
            return true;
        }
    }

    public void Print()
    {
        Console.WriteLine("Account Name: " + _name);
        Console.WriteLine("Account Balance: $" + _balance.ToString("0,000.00"));
        Console.WriteLine();
    }

    public string Name
    {
        get { return _name; }
    }
}
