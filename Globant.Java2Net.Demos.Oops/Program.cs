using System;

namespace Globant.Java2Net.Demos.Oops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the metering administration");
            int result;

            Car car = new Car("HVC480");
            Bike bike = new Bike("02542");
            Truck truck = new Truck("BMW554");

            do
            {
                Console.WriteLine("How many wheels will have the vehicle on your parking?");
                int wheels = int.Parse(Console.ReadLine());
                Console.WriteLine("10 minutes");
                if (wheels == 2)
                {
                    bike.parking();
                    bike.FindVehicle();
                    bike.getPlate();
                    bike.weels();
                    bike.CalculateRate(10, 2);

                }

                if (wheels == 4)
                {
                    car.parking();
                    car.FindVehicle();
                    car.getPlate();
                    car.weels();
                    car.CalculateRate(10, 4);
                }

                if (wheels == 18)
                {
                    truck.parking();
                    truck.FindVehicle();
                    truck.getPlate();
                    truck.weels();
                    truck.CalculateRate(10, 18);
                }

                if (wheels != 2 & wheels != 4 & wheels != 18)
                {
                    Console.WriteLine("Error, Try Again");
                }
                Console.WriteLine("Continue?");
                Console.WriteLine("1-Yes\n2-No?");
                result = int.Parse(Console.ReadLine());
            } while (result != 2);


        }



        internal interface IParkingFactory
        {
            int weels();

        }

        internal class Vehicle
        {
            public Vehicle(string plate)
            {
               plateVehicle = plate;

            }
            public virtual void parking()
            {
                Console.WriteLine("Parking");
            }

            public virtual void CalculateRate(int minutes, int weels)
            {

                Console.WriteLine("rate is: " + minutes * weels);
            }

            public void getPlate()
            {
                Console.WriteLine("The plate of the vehicle is: " + plateVehicle);
            }

            private readonly string plateVehicle;

        }

        internal class Bike : Vehicle, IParkingFactory
        {
            public Bike(string plateNumber) : base(plateNumber)
            {


            }

            public override void parking()
            {
                Console.WriteLine("BicycleParking!!!");
            }

            public int weels()
            {
                return 2;
            }

            public void FindVehicle()
            {
                Console.WriteLine("Finding a Bicycle!!!");

            }

            public override void CalculateRate(int minutes, int weels)
            {

                Console.WriteLine("rate is: " + minutes * weels);
            }

        }

        internal class Car : Vehicle, IParkingFactory
        {
            public Car(string plateNumber) : base(plateNumber)
            {


            }


            public int weels()
            {
                return 4;
            }

            public override void parking()
            {
                Console.WriteLine("Parking a Car!!!");
            }

            public override void CalculateRate(int minutes, int weels)
            {
                Console.WriteLine("rate is: " + minutes * weels);
            }
            public void FindVehicle()
            {
                Console.WriteLine("Finding a Car!!!");

            }
        }

        internal class Truck : Vehicle, IParkingFactory
        {
            public Truck(string plateNumber) : base(plateNumber)
            {


            }

            public override void parking()
            {
                Console.WriteLine("TruckParking");
            }


            public int weels()
            {
                return 18;
            }

            public void FindVehicle()
            {
                Console.WriteLine("Finding a Truck!!!");

            }
            public override void CalculateRate(int minutes, int weels)
            {
                Console.WriteLine("rate is: " + minutes * weels);
            }


        }
    }
}


