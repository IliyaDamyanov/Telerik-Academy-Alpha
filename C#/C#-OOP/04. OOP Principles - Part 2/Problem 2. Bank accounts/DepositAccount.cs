using System;

namespace Problem_2.Bank_accounts
{
    public class DepositAccount : Account , IDepositable , IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public decimal DepositMoney(decimal moneyToDesposit)
        {
            return this.Balance + moneyToDesposit;
        }

        public decimal WithdrawMoney(decimal moneyToWithdraw)
        {
            return this.Balance - moneyToWithdraw;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return 0;
            }
            return base.CalculateInterestAmount(months);
        }
    }
}
