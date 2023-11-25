
class BankAccount 
{
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
    
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextNumber = 123;

    private static long NextNumber()
    {
        return nextNumber++;
    }
    public bool Withdraw(decimal amount)
    {
        bool suffucentFunds = amount <= accBal;
        if (suffucentFunds) { accBal -= amount; }
        return suffucentFunds;
    }
    public bool Deposit(decimal amount)
    {
        bool correctDeposit = amount > 0;
        if (correctDeposit) { accBal += amount; }
        return correctDeposit;
    }
}
