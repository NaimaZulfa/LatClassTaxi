using System;
using System.Collections.Generic;
using System.Text;

namespace LatClassTaxi
{
    class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", driverName);
            if (onDuty)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }

            Console.WriteLine("Number of Passenger : {0}", NumPassenger);

        }

        public void PickUpPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("{0} sedang menjemput penumpang", driverName);
            }
            else
            {
                Console.WriteLine("{0} tidak menjemput penumpang", driverName);
            }
        }

        public void DropOffPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("{0} selesai mengantar penumpang", driverName);
            }
            else
            {
                Console.WriteLine("{0} tidak mengantar penumpang", driverName);
            }
        }
    }
}
