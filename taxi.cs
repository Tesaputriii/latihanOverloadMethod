using System;

namespace Program_Taxi
{
    public class taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumberOfPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
                {
                    Console.WriteLine("On Duty : yes");
                }else{
                    Console.WriteLine("On Duty : no");    
                }
            Console.WriteLine("Number Of Passanger : {0}", NumberOfPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
            Console.WriteLine();
        }

        public void DropOfPassenger()
        {
            Console.WriteLine("{0} selesai mengantarkan penumpang", DriverName);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            taxi saya = new taxi();

            saya.DriverName = "jono";
            saya.OnDuty = true;
            saya.NumberOfPassenger = 10;

            saya.TaxiInfo();
            saya.PickUpPassenger();
            saya.DropOfPassenger();

            Console.ReadKey();
        }
    }


}