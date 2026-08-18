using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
   
        public class DeliveryCenter
        {
            private Shipment[] shipments = new Shipment[20];

            public string CenterName
            {
                get;
                set;
            }

            public Driver Driver
            {
                get;
                set;
            }

            public DeliveryCenter(string centerName)
            {
                CenterName = centerName!;
                
            }

           
            public Shipment this[int index]
            {
                get
                {
                    if (index >= 0 && index < shipments.Length)
                    {
                        return shipments[index];
                    }

                    return null;
                }

                set
                {
                    if (index >= 0 && index < shipments.Length)
                    {
                        shipments[index] = value;
                    }
                }
            }

           
            public Shipment this[string trackingCode]
            {
                get
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i] != null)
                        {
                            if (shipments[i].TrackingCode == trackingCode)
                            {
                                return shipments[i];
                            }
                        }
                    }

                    return null;
                }
            }

            public bool AddShipment(Shipment shipment)
            {
                if (shipment == null)
                {
                    return false;
                }

                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] == null)
                    {
                        shipments[i] = shipment;
                        return true;
                    }
                }

                return false;
            }

            public bool RemoveShipment(string trackingCode)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                        {
                            shipments[i] = null;
                            return true;
                        }
                    }
                }

                return false;
            }

            public void PrintAllShipments()
            {
                Console.WriteLine("================================");
                Console.WriteLine("Delivery Center: " + CenterName);

                if (Driver != null)
                {
                    Console.WriteLine("Driver: " + Driver.FullName);
                }

                Console.WriteLine("================================");

                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                        shipments[i].PrintShipment();
                    }
                }
            }

            public void PrintTrackingStatuses()
            {
                Console.WriteLine("Tracking Status");
                Console.WriteLine("--------------------------------");

                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null)
                    {
                          if (shipments[i] is ITrackable trackableShipment)
                             {
                                  Console.WriteLine(trackableShipment.GetTrackingStatus());
                              }
                    //hna hn3ml check if the shipment implements ITrackable and print its tracking status

                }
            }
            }
        }
    }
