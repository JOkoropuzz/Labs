namespace StructType
{
    public enum AccountType { Checking, Deposit }
    public struct bankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
        
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            bankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            //goldAccount.accNo = 123;
            Console.WriteLine("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            goldAccount.accBal = 3200;
            Console.WriteLine($"Accont number {goldAccount.accNo}\nAccont ballance {goldAccount.accBal}\nAccont type {goldAccount.accType}");
        }
    }
}