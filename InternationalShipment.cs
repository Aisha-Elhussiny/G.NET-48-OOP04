using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{

        public class InternationalShipment :
            Shipment,
            ITrackable,
            IInsurable
        {
            private string destinationCountry;
            private decimal customsFee;

            public string DestinationCountry
            {
                get
                {
                    return destinationCountry;
                }

                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        destinationCountry = value;
                    }
                }
            }

            public decimal CustomsFee
            {
                get
                {
                    return customsFee;
                }

                set
                {
                    if (value >= 0)
                    {
                        customsFee = value;
                    }
                }
            }

            public InternationalShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                string destinationCountry,
                decimal customsFee)
                : base(
                      trackingCode,
                      description,
                      weight,
                      deliveryFee,
                      destination)
            {
                this.destinationCountry = "Unknown";
                this.customsFee = 0;

                DestinationCountry = destinationCountry;
                CustomsFee = customsFee;
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5) + CustomsFee;
                }
            }
        //3mlna override .

            public override void PrintShipment()
            {
                Console.WriteLine("International Shipment");
                Console.WriteLine("Tracking Code: " + TrackingCode);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Weight: " + Weight + " KG");
                Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
                Console.WriteLine("Destination: " + Destination.GetFullAddress());
                Console.WriteLine("Destination Country: " + DestinationCountry);
                Console.WriteLine("Customs Fee: " + CustomsFee + " EGP");
                Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
                Console.WriteLine("--------------------------------");
            }
        //3mlna override.

            public string GetTrackingStatus()
            {
                return "Shipment " + TrackingCode + " has been Delivered.";
            }
        //lazem astkhdmha 3shan heya fe interface ITrackable.
        
        public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.12m;
            }

        //lazem astkhdmha 3shan heya fe interface IInsurable.

        public virtual void GenerateCustomsReport()
            {
                Console.WriteLine("Customs report for shipment: " + TrackingCode);
            }
        }
    }
