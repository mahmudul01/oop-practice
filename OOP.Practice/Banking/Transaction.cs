namespace Banking
{
    public class Transaction
    {
        public void Transfer(Account accountFrom, Account accountTo, int ammount)
        {
            accountFrom.Withdraw(ammount);
            accountTo.Deposit(ammount);
        }
    }
}
