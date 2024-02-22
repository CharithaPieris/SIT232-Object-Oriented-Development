//BSCP|CS|62|114 Charitha Pieris

using System;

namespace ExceptionHandling
{
    class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Balance { get; private set; }

        public Account(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient fund");
            }
            Balance = Balance - amount;
        }
    }

    class Program
    {
        public static void Main()
        {
            try
            {
                Account account = new Account("Sergey", "P.", 100);
                account.Withdraw(1000);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("The following error detected: " +
                    exception.GetType().ToString() + " with message \"" +
                    exception.Message + "\"");
            }

            Console.ReadKey();
        }
    }
}
