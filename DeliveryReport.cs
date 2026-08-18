using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{

 
        public  class DeliveryReport
        {
            public static void PrintShipment(ITrackable shipment)
            {
                if (shipment != null)
                {
                    Console.WriteLine(shipment.GetTrackingStatus());
                }
            }
        //de method printshipment takes an ITrackable object as a parameter and prints its tracking status to the console. The method first checks if the shipment object is not null, and if it is not, it calls the GetTrackingStatus() method on the shipment object and prints the result to the console.

        public static void PrintInsurance(IInsurable shipment)
            {
                if (shipment != null)
                {
                    Console.WriteLine(
                        "Insurance Cost: "
                        + shipment.CalculateInsurance()
                        + " EGP");
                }
            }
        // The method printinsurance takes an IInsurable object as a parameter and prints its insurance cost to the console. The method first checks if the shipment object is not null, and if it is not, it calls the CalculateInsurance() method on the shipment object and prints the result to the console along with the currency "EGP".
    }
}
