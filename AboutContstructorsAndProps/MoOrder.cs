using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutConstructorsAndProps
{
    internal class MoOrder
    {
        TiisuWaakyePlace anotherWaakyeApp = new TiisuWaakyePlace(); // Created a reference to Tiisu Class to be able to place an order 
                                                                    // Its method will include the list of the order

        public void VroomToWaakye()
        {
            List<string> vehicleOrderInstance = new List<string>();
            vehicleOrderInstance.Add("Eggs in Stew");
            vehicleOrderInstance.Add("Salad");
            vehicleOrderInstance.Add("All the Shito You have");

            anotherWaakyeApp.BuyWaakye(10, vehicleOrderInstance);
        }
    }
}
