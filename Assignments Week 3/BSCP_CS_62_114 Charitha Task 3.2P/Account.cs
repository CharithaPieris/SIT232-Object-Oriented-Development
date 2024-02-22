//BSCP_CS_62_114 Charitha 

using System;

class Account
{
    private decimal _balance = 0;

    public bool Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public void Print()
    {
        Console.WriteLine($"Account Balance: {_balance:C}"); Console.WriteLine();
    }
}
