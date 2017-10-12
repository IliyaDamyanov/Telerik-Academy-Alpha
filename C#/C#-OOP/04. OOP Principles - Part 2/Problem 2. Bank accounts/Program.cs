using System;

namespace Problem_2.Bank_accounts
{
    class Program
    {
        static void Main()
        {
            LoanAccount acc = new LoanAccount(Customer.Individuals, 100, 10);
            acc.CalculateInterestAmount(5);
        }
    }
}
