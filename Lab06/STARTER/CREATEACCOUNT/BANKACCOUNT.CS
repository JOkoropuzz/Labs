
class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    public void Populate(long x, decimal y)
    {
        accNo = x;
        accBal = y;
        accType = AccountType.Checking;
    }
    public long Number()
    {
        return accNo;
    }

    public decimal Ballance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }
}
