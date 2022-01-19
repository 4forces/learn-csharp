namespace myProjects
{
    public class BankAcct // object
    {
        // Properties. Also'form fields' and their methods
        public string? Number { get; } // bank account number, which may have chars
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        // constructor
        public BankAcct(string name, decimal initialBalance)
        // Resolve warning: https://stackoverflow.com/questions/67505347/non-nullable-property-must-contain-a-non-null-value-when-exiting-constructor-co
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        // Functions
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

    }
}