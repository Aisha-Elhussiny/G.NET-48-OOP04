using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{

  
        public class StandardShipment : Shipment, ITrackable, IInsurable
        {
            public StandardShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination)
                : base(
                      trackingCode,
                      description,
                      weight,
                      deliveryFee,
                      destination)
            {
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5);
                }
            }
        //3mlt override l estimated cost 3shan heya m3molha abstract w kol wahed yhsb el cost bta3o

        public override void PrintShipment()
            {
                Console.WriteLine("Standard Shipment");
                Console.WriteLine("Tracking Code: " + TrackingCode);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Weight: " + Weight + " KG");
                Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
                Console.WriteLine("Destination: " + Destination.GetFullAddress());
                Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
                Console.WriteLine("--------------------------------");
            }
        //3mlt override l print shipment 3shan heya m3molha abstract.

            public string GetTrackingStatus()
            {
                return "Shipment " + TrackingCode + " is Ready.";
            }
        //lazem astkhdmha 3shan heya  fe interface ITrackable.

        public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.05m;
            }
        }
    //lazem astkhdmha 3shan heya fe interface IInsurable.

}
