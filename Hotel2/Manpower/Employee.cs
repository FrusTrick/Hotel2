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

        public void Work()
        {
            Console.WriteLine($"{Name} arbetar som {JobTitle} på {Department}");
        }
    }
}
