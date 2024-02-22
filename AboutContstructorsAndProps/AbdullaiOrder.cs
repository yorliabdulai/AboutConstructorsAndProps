using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutContstructorsAndProps
{
    internal class AbdullaiOrder
    {

        TiisuWaakyePlace waakyeApp = new TiisuWaakyePlace();
        List<string> AbdullaiWaakyeOrder = new List<string>(); //instantiate 
        public void BikeToWaakye()
        {
            AbdullaiWaakyeOrder.Add("Beef");
            AbdullaiWaakyeOrder.Add("Gari");
            AbdullaiWaakyeOrder.Add("Noodles");
            AbdullaiWaakyeOrder.Add("Fish");
            AbdullaiWaakyeOrder.Add("Noshito");

            waakyeApp.BuyWaakye(50, AbdullaiWaakyeOrder);

        }

    }
}