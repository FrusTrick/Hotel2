using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Consultant : Person
    {
        public int HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public Consultant(string name, int age, string employeeID, DateTime startDate, decimal salary, int hourlyRate, string consultingFirm) : base(name, age, employeeID, startDate, salary)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} Ger råd till hotellet om hur de kan förbättra sina rutiner.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}, Anställnings-ID: {EmployeeId}, Startdatum: {StartDate.ToShortDateString()}, Lön: {Salary:C}, Timpris: {HourlyRate:C}, Konsultfirma: {ConsultingFirm}");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name}, jag är {Age} år gammal och jag arbetar som konsult för {ConsultingFirm}.");
        }
    }
}
