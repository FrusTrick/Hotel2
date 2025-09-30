using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department {  get; set; }

        public Employee(string name, int age, string employeeID, DateTime startDate, decimal salary, string department, string jobTitle) : base(name, age, employeeID, startDate, salary)
        {
            JobTitle = jobTitle;
            Department = department;
        }
        

        public void Work()
        {
            Console.WriteLine($"{Name} arbetar som {JobTitle} på {Department}");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}, Anställnings-ID: {EmployeeId}, Startdatum: {StartDate.ToShortDateString()}, Lön: {Salary:C}, Jobbtitel: {JobTitle}, Avdelning: {Department}");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name}, jag är {Age} år gammal och jag arbetar som {JobTitle} på {Department} avdelningen.");
        }
    }
}
