using Hotel2.Manpower;

namespace Hotel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate1 = new DateTime(2020, 1, 1);
            DateTime startDate2 = new DateTime(2022, 3, 15);

            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", startDate1, 50000m, "Administration");
            Employee employee = new Employee("Erik Anställdsson", 30, "E001", startDate2, 30000m, "Front Desk", "Receptionist");

            Console.WriteLine("Manager");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();



        }
    }
}
