using Hotel2.Manpower;

namespace Hotel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> hotelStaff = new List<Person>();

            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2020, 1, 1), 50000m, "Administration");
            hotelStaff.Add(manager);
            Employee employee = new Employee("Erik Anställdsson", 30, "E001", new DateTime(2022, 3, 15), 30000m, "Front Desk", "Receptionist");
            hotelStaff.Add(employee);
            Consultant consultant = new Consultant("Eva Expert", 35, "C001", new DateTime(2023, 1, 1), 0, 1000, "Hotell Experterna AB", "HR");
            hotelStaff.Add(consultant);



            Console.WriteLine("Hotellets personal:");
            foreach (var person in hotelStaff)
            {
                person.PrintInfo();
                person.Introduce();

                if (person is Manager)
                {
                    manager.HoldMeeting();
                }
                else if (person is Employee)
                {
                    employee.Work();
                }
                else if (person is Consultant)
                {
                    consultant.GiveAdvice();
                }

                Console.WriteLine(); // Lägg till en tom rad för läsbarhet
            }



            //Console.WriteLine("Manager");
            //manager.PrintInfo();
            //manager.Introduce();
            //manager.HoldMeeting();

            //Console.WriteLine("\nEmployee");
            //employee.PrintInfo();
            //employee.Introduce();
            //employee.Work();


            //Console.WriteLine("\nConsultant:");
            //consultant.PrintInfo();
            //consultant.Introduce();
            //consultant.GiveAdvice();
            //Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            //Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");
        }
    }
}
