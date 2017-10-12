using System;

namespace Problem_2.Bank_accounts
{
    public class LoanAccount : Account , IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal DepositMoney(decimal moneyToDesposit)
        {
            return this.Balance + moneyToDesposit;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer==Customer.Individuals)
            {
                months -= 3;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
