using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Shohag", "Dhaka", 1, 3);
            Account account2 = new Account("Mahmudul", "Tangail", 1, 3);

            account1.Deposit(5000);
            account1.Withdraw(1000);


            var transaction = new Transaction();
            transaction.Transfer(account1, account2, 500);

            Console.WriteLine($"Account 1 balace: {account1.Balance}");
            Console.WriteLine($"Account 2 balace: {account2.Balance}");
        }
    }
}
