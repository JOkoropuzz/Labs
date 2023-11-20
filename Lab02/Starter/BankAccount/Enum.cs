using System.Security.Cryptography.X509Certificates;

namespace BankAccount
{
    internal class Enum
    {
        public enum AccountType { Checking, Deposit }
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platAccount;
            goldAccount = AccountType.Checking;
            platAccount = AccountType.Deposit;
            Console.WriteLine($"The Customer account type is {goldAccount}\nThe Customer account type is {platAccount}");
        }
    }
}