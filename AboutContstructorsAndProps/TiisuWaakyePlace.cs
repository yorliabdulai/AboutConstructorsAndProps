using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AboutConstructorsAndProps
{
    internal class TiisuWaakyePlace
    {
        public string TiisuWaakyeLocation { get; set; } = "Campus Corner";
        public bool notOpened { get; private set; } = false;
        public DateTime DateEstablished { get; } = new DateTime(2019, 12, 20); // Adjust with the actual establishment date

        public TiisuWaakyePlace()
        {
            DateTime currentTime = DateTime.Now;
            DateTime TiisuStartTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 20, 55, 0);

            if (currentTime < TiisuStartTime)
            {
                notOpened = true;
                Console.WriteLine($"Tiisu Waakye Place is not open. Opening time is {TiisuStartTime}");
                int minutesLeft = (int)(TiisuStartTime - currentTime).TotalMinutes;
                Console.WriteLine($"Please wait for {minutesLeft} minutes.");
            }
            else
            {
                Console.WriteLine("Welcome to Tiisu Waakye Place! Ready to Serve, shee sheee she! Order when ready");
            }
        }

        public int costOfWaakye = 15;

        public void BuyWaakye(int money, List<string> orders)
        {
            if (notOpened)
            {
                Console.WriteLine("Tiisu Waakye Place is not open yet. Please come back during opening hours.");
                return;
            }

            if (costOfWaakye < money)
            {
                Console.WriteLine("Order is being Placed");
            }
            else
            {
                Console.WriteLine("Your money no catch");
                return;
            }

            foreach (string item in orders)
            {
                Console.WriteLine($"Adding {item} to your big bowl");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Packaging started. Tiisu Waakye Place established on: " + DateEstablished);
            Thread.Sleep(3000);
            Console.WriteLine("Thanks for your patience");
            Console.WriteLine("Enjoy your waakye, come back soon");
        }
    }
}
