using System.Collections.Generic;

namespace myProjects
{
    public class BankAcct // object
    {
        // Properties. Also'form fields' and their methods
        public string Number { get; } = String.Empty; // bank account number, which may have chars
        public string Owner { get; set; }
        public decimal Balance {
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

        // constructor
        public BankAcct(string name, decimal initialBalance)
        // Resolve warning: https://stackoverflow.com/questions/67505347/non-nullable-property-must-contain-a-non-null-value-when-exiting-constructor-co
        {
            this.Owner = name;
            // this.Balance = initialBalance; // comment out since it throws error
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        // Functions
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            // checks for 'negative' deposit and 'rejects' if true
            if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit); // adding deposits
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0) // withdrawing more than what we have
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

    }
}