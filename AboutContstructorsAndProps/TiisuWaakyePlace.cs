using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutContstructorsAndProps
{
    internal class TiisuWaakyePlace
    {


        //Explicit Constructor vs Implict Constructor
        public string TiisuWaakyeLocation { get; set; } = "Campus Corner";
        //public DateTime DateEstablished { get; set; } = DateTime.Parse("12/201999)");
        public TiisuWaakyePlace() //parameterless
        {
            DateTime currentTime = DateTime.Now; //storing currentTime for later use.
            DateTime TiisuStartTime =
                new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 20, 55, 0);
            if (currentTime < TiisuStartTime)
            {
                Console.WriteLine("Bruh We are not open....");
            }
            else
            {
                Console.WriteLine("Ready to Serve,shee sheee she! Order when ready");
            }
        } //Constructor
        public int costOfWaakye = 15;
        // public int CostOfWaakey { get; set; } = 20; //property
        void BuyWaakye(int money, List<string> orders) //input parameters
        {

            if (costOfWaakye < money)
            {
                Console.WriteLine("Order is being Placed");

            }
            else
            {
                Console.WriteLine("Your money no catch");
            }
            foreach (string item in orders)
            {
                Console.WriteLine($"Adding {item} to your big bowl");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Packaging");
            Thread.Sleep(3000);
            Console.WriteLine("Thanks for your patience");
            Console.WriteLine("Enjoy your waakye, come back soon");
        }
    }
}