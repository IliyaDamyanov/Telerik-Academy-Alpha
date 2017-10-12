using System;

namespace Problem_2.Students_and_wor
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string Specifications()
        {
            return string.Format("{0:F2}", this.MoneyPerHour());
        }

        public override string TypeOfHuman()
        {
            return nameof(Worker);
        }
    }
}
