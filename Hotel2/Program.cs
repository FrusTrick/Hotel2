using Hotel2.Manpower;

namespace Hotel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2020, 1, 1), 50000m, "Administration");
            Employee employee = new Employee("Erik Anställdsson", 30, "E001", new DateTime(2022, 3, 15), 30000m, "Front Desk", "Receptionist");

            Console.WriteLine("Manager");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();
            manager.PlanBudget();

            Console.WriteLine("\nEmployee");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();


            Consultant consultant = new Consultant("Eva Expert", 35, "C001", new DateTime(2023, 1, 1), 0, 1000, "Hotell Experterna AB", "HR");
            Console.WriteLine("\nConsultant:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();
            Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");

            Housekeeper housekeeper = new Housekeeper("Anna Clean", 32);
            housekeeper.PrintInfo();
            housekeeper.Work();
        }
    }
}
