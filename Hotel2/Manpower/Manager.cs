using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    public class Manager : Person
    {
        
        public string Department { get; set; }

        public Manager(string name, int age, string employeeID, DateTime startDate, decimal salary, string department) : base(name, age, employeeID, startDate, salary)
        {
            Department = department;
        }


        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} håller ett personalmöte på hotellet.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}, Anställnings-ID: {EmployeeId}, Startdatum: {StartDate.ToShortDateString()}, Lön: {Salary:C}, Avdelning: {Department}");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name}, jag är {Age} år gammal och jag är chef för {Department} avdelningen.");
        }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name} planerar hotellets budget");
        }
    }
}
