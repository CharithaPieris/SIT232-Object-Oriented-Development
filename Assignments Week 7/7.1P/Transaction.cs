//Charitha Pieris BSCP|CS|62|114

using System;

namespace Task_7_1P
{

    // Baseclass for transaction classes
    abstract class Transaction
    {
        // Instance variables
        protected decimal _amount;
        protected Boolean _success;
        private Boolean _executed;
        private Boolean _reversed;
        private DateTime _dateStamp;

        // public properties
        public Boolean Success { get => _success; }
        public Boolean Executed { get => _executed; }
        public Boolean Reversed { get => _reversed; }
        public DateTime DateStamp { get => _dateStamp; }
        public decimal Amount { get => _amount; } // Added for the transaction history print


        // Creates a new Transaction object
        public Transaction(decimal amount)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                amount = 0;
                throw new ArgumentOutOfRangeException("Amount must be > $0.00");
            }
            // _executed, _success, _reversed false by default
        }

        public abstract string GetAccountName();


        // Writes the amount and status to the Console
        public virtual void Print()
        {
            Console.WriteLine(
                "Transaction amount: {0}, Executed: {1}, Success: {2}, Reversed: {3}",
                _amount.ToString("C"), _executed, _success, _reversed);
        }


        // Records execution of the transaction if not previously executed successfully
        public virtual void Execute()
        {
            if (_executed && _success)
            {
                throw new InvalidOperationException("Transaction previously executed");
            }
            _dateStamp = DateTime.Now;
            _executed = true;
        }


        // Records rolling back of the transaction if not previously rolled back
        public virtual void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction already reversed");
            }
            else if (!_success)
            {
                throw new InvalidOperationException(
                    "Transaction not successfully executed. Nothing to rollback.");
            }
            _dateStamp = DateTime.Now;
            _reversed = true;
        }
    }
}