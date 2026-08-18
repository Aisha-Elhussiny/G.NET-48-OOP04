namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) Abstraction
            #region a) What is Abstraction in Object-Oriented Programming?
            // it's focuses on simplifying complex systems by modeling classes based on the essential properties and behaviors an object should have, while hiding unnecessary implementation details. It allows developers to create abstract classes and interfaces that define a blueprint for derived classes, enabling them to implement specific functionality without exposing the underlying complexity.
            #endregion
            #region b)  Why is abstraction considered one of the four pillars of OOP?
            // because it reduces complexity, protects implementation details, and allows the programmer to focus on what an object does instead of how it does it.
            #endregion

            #endregion

            #region Q2)Abstract Classes vs. Interfaces
            #region a)  What is the difference between an Abstract Class and an Interface?
            // Abstract Class: An abstract class is a class that cannot be instantiated on its own and may contain both abstract methods (without implementation) and concrete methods (with implementation). It serves as a base for other classes to inherit from, allowing them to share common behavior and properties. Abstract classes can have fields, constructors, and access modifiers.
            // Interface: An interface is a contract that defines a set of methods and properties that a class must implement. It cannot contain any implementation details,or constructor, only method signatures. Interfaces are used to achieve multiple inheritance in C# since a class can implement multiple interfaces, but it can inherit from only one abstract class.
            #endregion
            #region b)  When would you choose an Interface instead of an Abstract Class?
            //  when you want to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for defining capabilities that can be shared across unrelated classes, promoting flexibility and decoupling in your code. If you need to provide default behavior or share common implementation details, an abstract class would be more appropriate.

            #endregion
            #region c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            // A class cannot inherit from multiple abstract classes in C#. C# supports single inheritance for classes, meaning a class can only inherit from one base class (abstract or concrete). However, a class can implement multiple interfaces, allowing it to inherit behavior from multiple sources. This is one of the key differences between abstract classes and interfaces in C#.
            #endregion
            #endregion

            #region practical project

                DeliveryAddress address1 =
                    new DeliveryAddress(
                        "Cairo",
                        "Tahrir Street",
                        15);

                DeliveryAddress address2 =
                    new DeliveryAddress(
                        "Giza",
                        "Pyramids Street",
                        20);

                DeliveryAddress address3 =
                    new DeliveryAddress(
                        "Alexandria",
                        "Sea Street",
                        10);

                StandardShipment standardShipment =
                    new StandardShipment(
                        "SH001",
                        "Laptop",
                        3,
                        80,
                        address1);

                ExpressShipment expressShipment =
                    new ExpressShipment(
                        "SH002",
                        "Mobile Phone",
                        2,
                        60,
                        address2,
                        30);

                InternationalShipment internationalShipment =
                    new InternationalShipment(
                        "SH003",
                        "Television",
                        8,
                        120,
                        address3,
                        "Germany",
                        100);

                Driver driver =
                    new Driver(
                        1,
                        "Ahmed Mohamed",
                        "01012345678");

                DeliveryCenter center =
                    new DeliveryCenter("Cairo Center");

                center.Driver = driver;

                center.AddShipment(standardShipment);
                center.AddShipment(expressShipment);
                center.AddShipment(internationalShipment);

                center.PrintAllShipments();

            
                center.PrintTrackingStatuses();

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Insurance");
                Console.WriteLine("--------------------------------");

                DeliveryReport.PrintInsurance(standardShipment);
                DeliveryReport.PrintInsurance(expressShipment);
                DeliveryReport.PrintInsurance(internationalShipment);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("ITrackable Array");
                Console.WriteLine("--------------------------------");

                ITrackable[] trackableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };
            //de l array of ITrackable and print the tracking status of each shipment using the GetTrackingStatus() method.

            for (int i = 0; i < trackableShipments.Length; i++)
                {
                    Console.WriteLine(
                        trackableShipments[i].GetTrackingStatus());
                }

                Console.WriteLine("--------------------------------");
                Console.WriteLine("IInsurable Array");
                Console.WriteLine("--------------------------------");

                IInsurable[] insurableShipments =
                {
                standardShipment,
                expressShipment,
                internationalShipment
            };
            //de l array of IInsurable and print the insurance cost of each shipment using the CalculateInsurance() method.

            for (int i = 0; i < insurableShipments.Length; i++)
                {
                    Console.WriteLine(
                        "Insurance Cost: "
                        + insurableShipments[i].CalculateInsurance()
                        + " EGP");
                }

            

              
    

            #endregion
}
    }
}
