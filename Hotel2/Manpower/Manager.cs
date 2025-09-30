using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Manager : Person
    {
        public Manager(string toName, int toAge, string toEmployeeID, DateTime toStartDate, decimal toSalary, string toDepartment) : base(toName, toAge, toEmployeeID, toStartDate, toSalary, toDepartment)
        {

        }


        public void HoldMeeting()
        {

        }
    }
}
