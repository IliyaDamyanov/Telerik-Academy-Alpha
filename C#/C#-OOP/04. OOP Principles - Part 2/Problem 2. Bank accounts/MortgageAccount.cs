using System;

namespace Problem_2.Bank_accounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal DepositMoney(decimal moneyToDesposit)
        {
            return this.Balance + moneyToDesposit;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer==Customer.Companies)
            {
                return 12 * this.InterestRate / 2 + (months - 12) * this.InterestRate;
            }
            else if (this.Customer==Customer.Individuals)
            {
                months -= 6;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
