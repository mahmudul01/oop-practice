namespace Banking
{
    public class Transaction
    {
        public void Transfer(Account accoutFrom, Account accoutTo, int ammount)
        {
            accoutFrom.Withdraw(ammount);
            accoutTo.Deposit(ammount);
        }
    }
}
