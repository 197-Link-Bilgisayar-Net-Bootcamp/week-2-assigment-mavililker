using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName => $"{Name} {LastName}";

        public abstract void SalaryCalculate();
        public decimal BaseSalaryCalculate()
        {
            return 10M;
        }
    }

    public class Manager : Person
    {
        public override void SalaryCalculate()
        {
            decimal baseSalary = BaseSalaryCalculate();

        }
    }

    public class Employee : Person
    {
        public override void SalaryCalculate()
        {
            throw new NotImplementedException();
        }
    }
}
