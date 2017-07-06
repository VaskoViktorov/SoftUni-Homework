using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;


        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string LastName
        {
            get
            {
                return base.LastName;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }


        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10m)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        private decimal SalaryPerHour(decimal weekS, decimal workHours)
        {
            decimal salaryPerHour = weekS / (workHours*5);

            return salaryPerHour;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nWeek Salary: {this.weekSalary:f2}\nHours per day: {this.workHoursPerDay:f2}\nSalary per hour: {SalaryPerHour(this.weekSalary, this.workHoursPerDay):f2}";
        }
    }
}
