using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Employee : Person
    {
        protected string JobTitle { get; set; }
        public Employee(string toName, int toAge, string toEmployeeID, DateTime toStartDate, decimal toSalary, string toJobTitle, string toDepartment) : base(toName, toAge, toEmployeeID, toStartDate, toSalary, toDepartment)
        {
            JobTitle = toJobTitle;
        }
        
        public void Work()
        {

        }
    }
}
