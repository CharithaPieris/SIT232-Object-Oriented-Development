//CHARITHA BSCP|CS|62|114


using System;
using System.Diagnostics;

namespace Task_6._2P
{
    enum MenuOption
    {
        CreateAccount,
        Withdraw,
        Deposit,
        Transfer,
        Print,
        Quit
    }


    class BankSystem
    {
        public static string ReadString(string prompt)
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


        /// Displays a menu of possible actions for the user to choose
        private static void DisplayMenu()
        {
            Console.WriteLine("\n********************");
            Console.WriteLine("*       Menu       *");
            Console.WriteLine("********************");
            Console.WriteLine("*  1. New Account  *");
            Console.WriteLine("*  2. Withdraw     *");
            Console.WriteLine("*  3. Deposit      *");
            Console.WriteLine("*  4. Transfer     *");
            Console.WriteLine("*  5. Print        *");
            Console.WriteLine("*  6. Quit         *");
            Console.WriteLine("********************");
        }


        static MenuOption ReadUserOption()
        {
            DisplayMenu();
            int option = ReadInteger("Choose an option", 1,
                Enum.GetNames(typeof(MenuOption)).Length);
            return (MenuOption)(option - 1);
        }


        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                decimal amount = ReadDecimal("Enter the amount");
                DepositTransaction transaction = new DepositTransaction(account, amount);
                try
                {
                    bank.ExecuteTransaction(transaction);
                }
                catch (InvalidOperationException)
                {
                    transaction.Print();
                    return;
                }
                transaction.Print();
            }
        }


        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                decimal amount = ReadDecimal("Enter the amount");
                WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
                try
                {
                    bank.ExecuteTransaction(transaction);
                }
                catch (InvalidOperationException)
                {
                    transaction.Print();
                    return;
                }
                transaction.Print();
            }
        }


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
                    TransferTransaction transaction = TransferTransaction.Builder
                        .FromAccount(from)
                        .ToAccount(to)
                        .Amount(amount)
                        .Build();
                    bank.ExecuteTransaction(transaction);
                    transaction.Print();
                }
                catch (Exception)
                {
                    // Currently this is handled in the TransferTransaction. This will be changed
                }
            }
        }


        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }

        

       static void CreateAccount(Bank bank)
        {
            string name = ReadString("Enter account name");
            decimal balance = ReadDecimal("Enter the opening balance");
            bank.AddAccount(new Account(name, balance));
        }

        private static Account FindAccount(Bank bank)
        {
            string name = ReadString("Enter the account name");
            Account account = bank.GetAccount(name);
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

                    case MenuOption.Print:
                        DoPrint(bank); break;

                    case MenuOption.Quit:
                    default:
                        Console.WriteLine("Goodbye");
                        System.Environment.Exit(0); // terminates the program
                        break; // unreachable
                }
            } while (true);
        }
    }
}