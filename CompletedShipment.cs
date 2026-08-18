using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
   
        public sealed class CompletedShipment :
            Shipment,
            ITrackable,
            IInsurable
        {
            public CompletedShipment(
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

            public override void PrintShipment()
            {
                Console.WriteLine("Completed Shipment");
                Console.WriteLine("Tracking Code: " + TrackingCode);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Weight: " + Weight + " KG");
                Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
                Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
                Console.WriteLine("--------------------------------");
            }

            public string GetTrackingStatus()
            {
                return "Shipment " + TrackingCode + " is Completed.";
            }

            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.05m;
            }
        }
    }
