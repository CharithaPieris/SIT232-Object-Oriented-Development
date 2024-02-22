//Charitha Pieris BSCP|CS|62|114

using System;
using System.Collections.Generic;

namespace Task_7_1P
{
    // Prototype for a bank to hold accounts
    class Bank
    {
        private List<Account> _accounts;
        public List<Transaction> Transactions { get; private set; }


        // Creates an empty bank object with a list for accounts
        public Bank()
        {
            _accounts = new List<Account>();
            Transactions = new List<Transaction>();
        }


        // Adds an account to the Bank accounts register
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }


        // Returns the first Account corresponding to the name, or null if there is no account matching the criteria
        // Account matching the provided name, or null

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


        // Executes a transaction
        public void Execute(Transaction transaction)
        {
            Transactions.Add(transaction);
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


        // Rolls a transaction back
        public void Rollback(Transaction transaction)
        {
            try
            {
                transaction.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occurred in rolling the transaction back");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }

 
        // Helper function for PrintTransactionHistory that converts the type of the transaction to a string
        public string TransactionType(Transaction transaction)
        {
            switch (transaction.GetType().ToString())
            {
                case "Task_7_1P.DepositTransaction":
                    return "Deposit";
                case "Task_7_1P.WithdrawTransaction":
                    return "Withdraw";
                case "Task_7_1P.TransferTransaction":
                    return "Transfer";
            }
            return "Unknown";
        }


        // Helper function for PrintTransactionHistory that converts the current status to a string representation
        public string TransactionStatus(Transaction transaction)
        {
            if (!transaction.Executed)
            {
                return "Pending";
            }
            else if (transaction.Reversed)
            {
                return "Reversed";
            }
            else if (!transaction.Success)
            {
                return "Incomplete";
            }
            else
            {
                return "Complete";
            }
        }


        // Writes the list of transactions to the Console in a table format
        public void PrintTransactionHistory()
        {
            string transactionType = "";
            string transactionStatus = "";
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("| {0,2} |{1,-25} | {2,-15}|{3,15} | {4,15} |", "#",
                    "DateTime", "Type", "Amount", "Status");
            Console.WriteLine(new String('=', 85));
            for (int i = 0; i < Transactions.Count; i++)
            {
                transactionType = TransactionType(Transactions[i]);
                transactionStatus = TransactionStatus(Transactions[i]);
                Console.WriteLine("| {0,2} |{1,-25} | {2,-15}|{3,15} | {4,15} |", i + 1,
                    Transactions[i].DateStamp, transactionType,
                    Transactions[i].Amount.ToString("C"), transactionStatus);
            }
            Console.WriteLine(new String('=', 85));
        }
    }
}