using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Housekeeper : Employee
    {
        public Housekeeper(string name, int age, string employeeID, DateTime startDate, decimal salary, string department, string jobTitle) : base(name, age, employeeID, startDate, salary, department, jobTitle)
        {

        }

        public Housekeeper(string name, int age) :base()
        {
            Name = name;
            Age = age;
        }
        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotellrummen");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nNamn: {Name} Ålder: {Age}");
        }
    }
}
