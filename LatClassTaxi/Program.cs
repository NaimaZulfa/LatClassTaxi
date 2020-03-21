using System;

namespace LatClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.driverName = "Zulfa";
            taxi.onDuty = true;
            taxi.NumPassenger = 10;


            taxi.TaxiInfo();


            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
