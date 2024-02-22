//Charitha Pieris BSCP|CS|62|114

using System;

namespace Task_7_1P
{

    // Prototype for a transfer transaction
    class TransferTransaction : Transaction
    {
        // Instance variables
        private Account _fromAccount;
        private Account _toAccount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;

        // Properties
        public new bool Success { get => (_deposit.Success && _withdraw.Success); }


        // Constructor for a transfer transaction
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _withdraw = new WithdrawTransaction(_fromAccount, _amount);
            _deposit = new DepositTransaction(_toAccount, _amount);
        }


        // Prints the details of the transfer
        public override void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1, -20}|{2, 20}|{3, 20}|",
                "FROM ACCOUNT", "To ACCOUNT", "TRANSFER AMOUNT", "STATUS");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, -20}|{2, 20}|", _fromAccount.Name, _toAccount.Name, _amount.ToString("C"));
            if (!Executed)
            {
                Console.WriteLine("{0, 20}|", "Pending");
            }
            else if (Reversed)
            {
                Console.WriteLine("{0, 20}|", "Transfer reversed");
            }
            else if (Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer complete");
            }
            else if (!Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer failed");
            }
            Console.WriteLine(new String('-', 85));
        }


        // Executes the transfer
        public override void Execute()
        {
            base.Execute();

            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Transfer failed with reason: " + exception.Message);
                _withdraw.Print();
            }

            if (_withdraw.Success)
            {
                try
                {
                    _deposit.Execute();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Transfer failed with reason: " + exception.Message);
                    _deposit.Print();
                    try
                    {
                        _withdraw.Rollback();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("Withdraw could not be reversed with reason: " + e.Message);
                        _withdraw.Print();
                        return;
                    }
                }
            }
            _success = true;
        }


        // Rolls the transfer back
        public override void Rollback()
        {
            base.Rollback();

            if (this.Success)
            {
                try
                {
                    _deposit.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback deposit: "
                        + exception.Message);
                    return;
                }

                try
                {
                    _withdraw.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback withdraw: "
                        + exception.Message);
                    return;
                }
            }
        }

        public override string GetAccountName()
        {
            return _fromAccount.Name + " -> " + _toAccount.Name;
        }
    }
}