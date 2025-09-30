using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string EmployeeId { get; set; }
        protected DateTime StartDate { get; set; }
        protected decimal Salary { get; set; }

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }

        public virtual void PrintInfo()
        {

        }
        public virtual void Introduce()
        {

        }
    }
}
