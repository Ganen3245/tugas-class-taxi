using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassTaxi
{
    internal class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int numPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", driverName);
            Console.WriteLine("On Duty: {0}", onDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger: {0}", numPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", driverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang", driverName);
        }
    }

}
