using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
   public abstract class Shipment
        {
            private string trackingCode;
            private string description;
            private decimal weight;
            private decimal deliveryFee;

            public string TrackingCode
            {
                get
                {
                    return trackingCode;
                }

                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        trackingCode = value;
                    }
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }

                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        description = value;
                    }
                }
            }

            public decimal Weight
            {
                get
                {
                    return weight;
                }

                set
                {
                    if (value > 0)
                    {
                        weight = value;
                    }
                }
            }

            public decimal DeliveryFee
            {
                get
                {
                    return deliveryFee;
                }

                private set
                {
                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
            }

            public DeliveryAddress Destination
            {
                get;
                set;
            }

           
            public abstract decimal EstimatedCost
            {
                get;
            }
        //3mlt estimated cost abstract 3shan kol class y3ml override w y7sb el cost bta3o

        public Shipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination)
            {
             
                this.trackingCode = "Unknown";
                this.description = "Unknown";
                this.weight = 1;
                this.deliveryFee = 1;

                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }

            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    DeliveryFee = newFee;
                }
            }

            
            public void UpdateWeight(decimal newWeight)
            {
                if (newWeight > 0)
                {
                    Weight = newWeight;
                }
            }

            
            public void UpdateWeight(
                decimal newWeight,
                decimal extraPackingWeight)
            {
                decimal totalWeight = newWeight + extraPackingWeight;

                if (totalWeight > 0)
                {
                    Weight = totalWeight;
                }
            }

            
            public abstract void PrintShipment();
        //3mlt print shipment abstract brdo 3shan kol class y3ml override w y print hagto
    }
}
