using System;

namespace Banking
{  
    public class Account
    {
        public string Name;
        public string Address;
        public int Age;
        public int NId;
        public int Balance { get; private set; }
        public Account(string name, string address, int age, int nid)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Ivalid name");

            Name = name;
            Address = address;
            Age = age;
            NId = nid;
          
        }

        public void Deposit(int ammount)
        {
            Console.WriteLine("Cash in");
            Balance = Balance + ammount;
            Console.WriteLine($"Total account balance is:{Balance}");
        }
        public void Withdraw(int ammount)
        {
            Console.WriteLine("Cash out");
            Balance = Balance - ammount;
            Console.WriteLine($"Total account balance is:{Balance}");
        }
    }
}
