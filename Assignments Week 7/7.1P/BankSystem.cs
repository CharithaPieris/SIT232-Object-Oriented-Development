//Charitha Pieris BSCP|CS|62|114

using System;

namespace Task_7_1P
{
    enum MenuOption
    {
        CreateAccount,
        Withdraw,
        Deposit,
        Transfer,
        Rollback,
        Print,
        Quit
    }

    // BankSystem implements a banking system to operate on accounts
    class BankSystem
    {
        public static String ReadString(String prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }

        public static int ReadInteger(String prompt)
        {
            int number = 0;
            string numberInput = ReadString(prompt);
            while (!(int.TryParse(numberInput, out number)))
            {
                Console.WriteLine("Please enter a whole number");
                numberInput = ReadString(prompt);
            }
            return Convert.ToInt32(numberInput);
        }

        public static int ReadInteger(String prompt, int minimum, int maximum)
        {
            int number = ReadInteger(prompt);
            while (number < minimum || number > maximum)
            {
                Console.WriteLine("Please enter a whole number from " +
                                  minimum + " to " + maximum);
                number = ReadInteger(prompt);
            }
            return number;
        }


        public static decimal ReadDecimal(String prompt)
        {
            decimal number = 0;
            string numberInput = ReadString(prompt);
            while (!(decimal.TryParse(numberInput, out number)) || number < 0)
            {
                Console.WriteLine("Please enter a decimal number, $0.00 or greater");
                numberInput = ReadString(prompt);
            }
            return Convert.ToDecimal(numberInput);
        }

    
        // Displays a menu of possible actions for the user to choose
        private static void DisplayMenu()
        {
            Console.WriteLine("\n********************");
            Console.WriteLine("*       Menu       *");
            Console.WriteLine("********************");
            Console.WriteLine("*  1. New Account  *");
            Console.WriteLine("*  2. Withdraw     *");
            Console.WriteLine("*  3. Deposit      *");
            Console.WriteLine("*  4. Transfer     *");
            Console.WriteLine("*  5. Rollback     *");
            Console.WriteLine("*  6. Print        *");
            Console.WriteLine("*  7. Quit         *");
            Console.WriteLine("********************");
        }


        // Returns a menu option chosen by the user
       
        // MenuOption chosen by the user
        private static MenuOption ReadUserOption()
        {
            DisplayMenu();
            int option = ReadInteger("Choose an option", 1,
                Enum.GetNames(typeof(MenuOption)).Length);
            return (MenuOption)(option - 1);
        }


        // Attempts to deposit funds into an account at a bank
        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                decimal amount = ReadDecimal("Enter the amount");
                DepositTransaction deposit = new DepositTransaction(account, amount);
                try
                {
                    bank.Execute(deposit);
                }
                catch (InvalidOperationException)
                {
                    deposit.Print();
                    return;
                }
                deposit.Print();
            }
        }

        // Attempts to withdraw funds from an account at a bank
        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                decimal amount = ReadDecimal("Enter the amount");
                WithdrawTransaction withdraw = new WithdrawTransaction(account, amount);
                try
                {
                    bank.Execute(withdraw);
                }
                catch (InvalidOperationException)
                {
                    withdraw.Print();
                    return;
                }
                withdraw.Print();
            }
        }

        

        // to transfer between
        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("Transfer from:");
            Account from = FindAccount(bank);
            Console.WriteLine("Transfer to:");
            Account to = FindAccount(bank);
            if (from != null && to != null)
            {
                decimal amount = ReadDecimal("Enter the amount");
                try
                {
                    TransferTransaction transfer = new TransferTransaction(from, to, amount);
                    bank.Execute(transfer);
                    transfer.Print();
                }
                catch (Exception)
                {
                    
                }
            }
        }


        // Outputs the account name and balance
        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }


        // Prints a list of transactions and allows them to be rolled back if necessary
        static void DoRollback(Bank bank)
        {
            bank.PrintTransactionHistory();
            int result = ReadInteger(
                "Enter transaction # to rollback (0 for no rollback)",
                0, bank.Transactions.Count);

            if (result == 0)
                return;

            bank.Rollback(bank.Transactions[result - 1]);
        }


        // Creates a new account and adds it to the Bank
        static void CreateAccount(Bank bank)
        {
            string name = ReadString("Enter account name");
            decimal balance = ReadDecimal("Enter the opening balance");
            bank.AddAccount(new Account(name, balance));
        }

        private static Account FindAccount(Bank bank)
        {
            Account account = null;
            string name = ReadString("Enter the account name");
            account = bank.GetAccount(name);
            if (account == null)
            {
                Console.WriteLine("That account name does not exist at this bank");
            }
            return account;
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();

            do
            {
                MenuOption chosen = ReadUserOption();
                switch (chosen)
                {
                    case MenuOption.CreateAccount:
                        CreateAccount(bank); break;

                    case MenuOption.Withdraw:
                        DoWithdraw(bank); break;

                    case MenuOption.Deposit:
                        DoDeposit(bank); break;

                    case MenuOption.Transfer:
                        DoTransfer(bank); break;

                    case MenuOption.Rollback:
                        DoRollback(bank); break;

                    case MenuOption.Print:
                        DoPrint(bank); break;

                    case MenuOption.Quit:
                    default:
                        Console.WriteLine("Goodbye");
                        return; // Terminates the program
                }
            } while (true);
        }
    }
}