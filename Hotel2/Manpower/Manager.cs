using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2.Manpower
{
    internal class Manager : Person
    {
        public string Department { get; set; }

        public Manager()
        {
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} håller ett personalmöte på hotellet.");
        }
    }
}
