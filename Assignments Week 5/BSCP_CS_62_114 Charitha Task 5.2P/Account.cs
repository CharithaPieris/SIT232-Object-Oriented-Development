using System;

namespace Task_4._2P
{
    // A bank account class to hold the account name and balance details
    class Account
    {
        // Instance variables
        private String _name;
        private decimal _balance;

        public String Name { get => _name; }
        public decimal Balance { get => _balance; }


        public Account(String name, decimal balance = 0)
        {
            _name = name;
            if (balance <= 0)
                return;
            _balance = balance;
        }


        // Deposits money into the account
        public Boolean Deposit(decimal amount)
        {
            if ((amount < 0) || (amount == decimal.MaxValue))
                return false;

            _balance += amount;
            return true;
        }

     
        // Withdraws money from the account (with no overdraw protection currently)
        public Boolean Withdraw(decimal amount)
        {
            if ((amount < 0) || (amount > _balance))
                return false;

            _balance -= amount;
            return true;
        }

        /// Outputs the account name and current balance as a string
        public void Print()
        {
            Console.WriteLine("Account Name: {0}, Balance: {1}",
                _name, _balance.ToString("C"));
        }
    }
}