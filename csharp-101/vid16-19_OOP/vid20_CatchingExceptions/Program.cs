// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Worlds!");

using System;

namespace myProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAcct("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(500,DateTime.Now,"Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100,DateTime.Now,"Friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}