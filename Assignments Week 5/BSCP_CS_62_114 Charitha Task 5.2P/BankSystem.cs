using System;
using System.Diagnostics;

namespace Task_4._2P
{
    enum MenuOption
    {
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
            string? input = Console.ReadLine();
            return input ?? string.Empty;
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
            while (!(decimal.TryParse(numberInput, out number)) || number <= 0)
            {
                Console.WriteLine("Please enter a decimal number greater than $0.00");
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
            Console.WriteLine("*  1. Withdraw     *");
            Console.WriteLine("*  2. Deposit      *");
            Console.WriteLine("*  3. Transfer     *");
            Console.WriteLine("*  4. Print        *");
            Console.WriteLine("*  5. Quit         *");
            Console.WriteLine("********************");
        }


        static MenuOption ReadUserOption()
        {
            DisplayMenu();
            int option = ReadInteger("Choose an option", 1,
                Enum.GetNames(typeof(MenuOption)).Length);
            return (MenuOption)(option - 1);
        }


        static void DoDeposit(Account account)
        {
            decimal amount = ReadDecimal("Enter the amount");
            DepositTransaction transaction = new DepositTransaction(account, amount);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException)
            {
                transaction.Print();
                return;
            }
            transaction.Print();
        }


        static void DoWithdraw(Account account)
        {
            decimal amount = ReadDecimal("Enter the amount");
            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException)
            {
                transaction.Print();
                return;
            }
            transaction.Print();
        }


        static void DoTransfer(Account mainAccount, Account acc1, Account acc2, Account acc3, Account acc4)
{
    Console.WriteLine();
    Console.WriteLine("Which account do you want to transfer:");
    Console.WriteLine("1. " + acc1.Name);
    Console.WriteLine("2. " + acc2.Name);
    Console.WriteLine("3. " + acc3.Name);
    Console.WriteLine("4. " + acc4.Name);

    int destinationOption = ReadInteger("Enter the option", 1, 4);

    Account toAccount;

    switch (destinationOption)
    {
        case 1:
            toAccount = acc1;
            break;
        case 2:
            toAccount = acc2;
            break;
        case 3:
            toAccount = acc3;
            break;
        case 4:
            toAccount = acc4;
            break;
        default:
            Console.WriteLine("Invalid option. Transfer canceled.");
            return;
    }

    decimal amount = ReadDecimal("Enter the amount to transfer");
    Console.WriteLine();

    TransferTransaction transfer = new TransferTransaction(mainAccount, toAccount, amount);
    try
    {
        transfer.Execute();
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine("Transfer failed. Insufficient funds or invalid amount.");
        return;
    }
    transfer.Print();
}


        static void DoPrint(Account account)
        {
            account.Print();
        }

        

        static void Main(string[] args)
        {
            /*********************************************************
             *  TESTS
             ********************************************************/
            Account acc = new Account("Charitha Pieris");
            Account acc1 = new Account("Sachintha Frenando", 100);
            Account acc2 = new Account("Manusha Fernando", -500);
            Account acc3 = new Account("Ruhansa Batuwattha", 1000);
            Account acc4 = new Account("Charuka Fernando", 300);


            Debug.Assert(acc.Balance == 0);
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(acc2.Balance == 0);

            // Test deposit success and rollback
            DepositTransaction dep = new DepositTransaction(acc, 500);

            dep.Print();
            dep.Execute();
            Debug.Assert(acc.Balance == 500);
            Debug.Assert(dep.Executed == true);
            Debug.Assert(dep.Success == true);
            dep.Print();

            dep.Rollback();
            Debug.Assert(acc.Balance == 0);
            Debug.Assert(dep.Reversed == true);
            dep.Print();

            Console.WriteLine("\n\n");

            // Test withdraw success and rollback
            WithdrawTransaction with = new WithdrawTransaction(acc1, 50);

            with.Print();
            with.Execute();
            Debug.Assert(acc1.Balance == 50);
            Debug.Assert(with.Executed == true);
            Debug.Assert(with.Success == true);
            with.Print();

            with.Rollback();
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(with.Reversed == true);
            with.Print();

            Console.WriteLine("\n\n");

            // Test transfer success and rollback
            TransferTransaction tran = new TransferTransaction(acc1, acc, 50);

            tran.Print();
            tran.Execute();
            Debug.Assert(acc.Balance == 50);
            Debug.Assert(acc1.Balance == 50);
            Debug.Assert(tran.Executed == true);
            Debug.Assert(tran.Success == true);

            tran.Rollback();
            Debug.Assert(acc.Balance == 0);
            Debug.Assert(acc1.Balance == 100);
            Debug.Assert(tran.Reversed == true);
            tran.Print();

            Console.WriteLine("\n\n");

            // Test withdraw failure when there is insufficient funds to complete the transaction
            WithdrawTransaction with2 = new WithdrawTransaction(acc, 100);

            with2.Print();
            try
            {
                with2.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Debug.Assert(acc.Balance == 0);
            Debug.Assert(with2.Success == false);
            Debug.Assert(with2.Executed == true);
            with2.Print();

            DepositTransaction dep2 = new DepositTransaction(acc, 500);

            dep2.Execute();
            dep2.Print();

            try
            {
                with2.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Debug.Assert(acc.Balance == 400);
            Debug.Assert(with2.Success == true);
            Debug.Assert(with2.Executed == true);
            with2.Print();

            Console.WriteLine("\n\n");

            // Test fail to rollback before deposit or withdraw are
            DepositTransaction dep3 = new DepositTransaction(acc, 500);
            WithdrawTransaction with3 = new WithdrawTransaction(acc, 500);
            TransferTransaction tran2 = new TransferTransaction(acc, acc1, 200);

            try
            {
                dep3.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                with3.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                tran2.Rollback();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("\n\n");

            // Try to rollback deposit from account with insufficient funds
            DepositTransaction dep4 = new DepositTransaction(acc2, 100);
            WithdrawTransaction with4 = new WithdrawTransaction(acc2, 100);

            dep4.Execute();
            with4.Execute();
            try
            {
                dep4.Rollback();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("\n\n");

            /*********************************************************
             *  CLI
             ********************************************************/
            do
            {
                MenuOption chosen = ReadUserOption();
                switch (chosen)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(acc); break;
                    case MenuOption.Deposit:
                        DoDeposit(acc); break;
                    case MenuOption.Transfer:
                        DoTransfer(acc, acc1, acc2, acc3, acc4); break;
                    case MenuOption.Print:
                        DoPrint(acc); break;
                    case MenuOption.Quit:
                    default:
                        Console.WriteLine("Goodbye");
                        System.Environment.Exit(0); // terminates the program
                        break; 
                }
            } while (true);


            
        }
    }
}