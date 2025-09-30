using Hotel2.Manpower;

namespace Hotel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Manager
            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2020, 1, 1), 50000m, "Administration");

            // Skapa en Employee
            Employee employee = new Employee("Erik Eriksson", 30, "E001", new DateTime(2022, 3, 15), 30000m, "Receptionist", "Front Desk");

            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();
        }
    }
}
