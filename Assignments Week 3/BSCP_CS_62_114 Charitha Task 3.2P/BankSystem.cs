//BSCP_CS_62_114 Charitha 

using System;

enum MenuOption
{
    Withdraw = 1,
    Deposit,
    Print,
    Quit
}

class BankSystem
{
    static void Main(string[] args)
    {
        Account account = new Account(); // Create an account

        do
        {
            MenuOption choice = ReadUserOption(); // Read user's choice

            // Respond to the user's choice
            switch (choice)
            {
                case MenuOption.Withdraw:
                    DoWithdraw(account);
                    break;
                case MenuOption.Deposit:
                    DoDeposit(account);
                    break;
                case MenuOption.Print:
                    DoPrint(account);
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Exiting the program.");
                    return;
            }
        } while (true);
    }

    static MenuOption ReadUserOption()
    {
        MenuOption choice;
        do
        {
            Console.WriteLine("__________________________");
            Console.WriteLine("|          Menu          |");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|      1. Withdraw       |");
            Console.WriteLine("|      2. Deposit        |");
            Console.WriteLine("|      3. Print          |");
            Console.WriteLine("|      4. Quit           |");
            Console.WriteLine("|________________________|");
            Console.Write("Select an option : ");
            
            if (Enum.TryParse(Console.ReadLine(), out choice) && Enum.IsDefined(typeof(MenuOption), choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option : ."); Console.WriteLine();
            }
        } while (true);
    }

    static void DoDeposit(Account account)
    {
        Console.Write("Enter the amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            bool success = account.Deposit(amount);
            if (success)
            {
                Console.WriteLine("** Deposit successful. **"); Console.WriteLine();
            }
            else
            {
                Console.WriteLine("** Deposit failed. **"); Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("** Invalid amount. Deposit must be a positive number. **"); Console.WriteLine();
        }
    }

    static void DoWithdraw(Account account)
    {
        Console.Write("Enter the amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            bool success = account.Withdraw(amount);
            if (success)
            {
                Console.WriteLine("** Withdrawal successful. **"); Console.WriteLine();
            }
            else
            {
                Console.WriteLine("** Withdrawal failed. Insufficient balance. **"); Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("** Invalid amount. Withdrawal must be a positive number. **"); Console.WriteLine();
        }
    }

    static void DoPrint(Account account)
    {
        account.Print();
    }
}
