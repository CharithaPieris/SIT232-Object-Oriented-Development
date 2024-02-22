//CHARITHA BSCP|CS|62|114


using System;
using System.Collections.Generic;

namespace Task_6._2P
{
    class Bank
    {
        // Instance variables
        private List<Account> _accounts;


        // Creates an empty bank object with a list for accounts
        public Bank()
        {
            _accounts = new List<Account>();
        }


        // Adds an account to the Bank accounts register
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                {
                    return account;
                }
            }
            return null;
        }


        // Executes a deposit into an account
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in executing the transaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }


        // Executes a WithdrawTransaction on an account
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in executing the transaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }


        // Transfers funds between accounts held by the bank
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in executing the transaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }
    }
}