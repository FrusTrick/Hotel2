using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Person (string toName, int toAge, string toEmployeeID, DateTime toStartDate, decimal toSalary, string toDepartment)
        {
            Name = toName;
            Age = toAge;
            EmployeeId = toEmployeeID;
            StartDate = toStartDate;
            Salary = toSalary;
            Department = toDepartment;
        }

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }

        public Person()
        {
        }

        public virtual void PrintInfo()
        {

        }
        public virtual void Introduce()
        {

        }
    }
}
