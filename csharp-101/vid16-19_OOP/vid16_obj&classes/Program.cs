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
        }
    }
}