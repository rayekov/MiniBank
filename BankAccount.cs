﻿namespace MiniBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;

                }
                return balance;


            }
        }
        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now,"Initial Balance");

        }
        public void MakeDeposit(decimal amount, DateTime date, string note )
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of Deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);  
            allTransactions.Add(deposit);
        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount<=0)
            {
                throw  new ArgumentOutOfRangeException(nameof(amount),"Amount of Withdrawal must be positive");
            }
            if (Balance - amount <0)
            {
                throw new InvalidOperationException("Insufficient funds for this operation");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
