using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class Employee
    {
        public string _firstName;
        public string _lastName;
        public string _payroll;
        public int _tax;
        public int _experience;
        public Employee(string firstName, string lastName/*, string payroll, int experience*/)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void PayrollAndTaxCalculator(string payroll, int experience)
        {
            if (experience < 3)
            {
                if (payroll == "Director")
                {
                    _experience = 500000;
                    _tax = (_experience * 21) / 100;
                }
                else if (payroll == "DeputyDirector")
                {
                    _experience = 300000;
                    _tax = (_experience * 21) / 100;
                }
                else
                {
                    _experience = 100000;
                    _tax = (_experience * 21) / 100;
                    _payroll = "Banvor";
                }
            }
            else if (experience > 3)
            {
                if (payroll == "Director")
                {
                    _experience = 700000;
                    _tax = (_experience * 21) / 100;
                }
                else if (payroll == "DeputyDirector")
                {
                    _experience = 500000;
                    _tax = (_experience * 21) / 100;
                }
                else
                {
                    _experience = 300000;
                    _tax = (_experience * 21) / 100;
                    _payroll = "Banvor";
                }
            }
            else
            {
                if (payroll == "Director")
                {
                    _experience = 1000000;
                    _tax = (_experience * 21) / 100;
                }
                else if (payroll == "DeputyDirector")
                {
                    _experience = 700000;
                    _tax = (_experience * 21) / 100;
                }
                else
                {
                    _experience = 500000;
                    _tax = (_experience * 21) / 100;
                    _payroll = "Banvor";
                }
            }
            Console.WriteLine($"_firstName - {_firstName}, _lastName - {_lastName}, _payroll - {_payroll}, _tax - {_tax}, _experience - {_experience}");
        }
    }
}
