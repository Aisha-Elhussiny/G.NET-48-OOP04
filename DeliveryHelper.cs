using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
   
        public  class DeliveryHelper
        {
            public static void PrintShipmentDetails(Shipment shipment)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                }
            }
        }
    }
