using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExercise
{
    class Vehicle
    {
        public string type;
        public string make;
        public string model;
        public int price;
        public Boolean sold;

        public static int totalValueSold = 0;
        public static int totalValueInStock = 0;

        public Vehicle(string type, string make, string model, int price)
        {
            this.type = type;
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;

            Vehicle.totalValueInStock++;
        }

        public void SoldVehicle(int price)
        {
            this.price = price;
            this.sold = true;
            Vehicle.totalValueSold++;
            totalValueInStock--;
            //Console.WriteLine("The {0} has been sold for £{1:N0}.", this.make, this.price);
        }

        public static void ListofVehicles(List<Vehicle> allVehicle)
        {
            foreach(Vehicle v in allVehicle )
            {
               // Console.Write("Type: {0}, Make and Model: {1} {2}, price: £{3:N0}.", v.type, v.make, v.model, v.price);

                if (v.type == "car")
                {
                    //Console.WriteLine("The list of cars: ");
                    Console.Write("\nMake and Model: {0} {1}, price: £{2:N0}.", v.make, v.model, v.price); ;
                    
                }
                if (v.type == "MotorCycle")
                {
                   //Console.WriteLine("The list of motocycles: ");
                    Console.Write("\nMake and Model: {0} {1}, price: £{2:N0}.", v.make, v.model, v.price); ;

                }
                if(v.sold == true)
                {
                    Console.WriteLine("This vehicle is sold.");
                }
                else
                {
                    Console.WriteLine("This vehicle is Unsold.")
                }
            }
                      
        }
    }

    class Car : Vehicle
    {
        public static int numberOfCars;

        public Car (string make, string model, int price, string type = "car") : base(type, make, model, price)
        {
            numberOfCars++;
        }
      
        public void SoldCar(int price)
        {
            this.price = price;
            this.sold = true;
            numberOfCars--;
            totalValueInStock--;
            totalValueSold++;
            Console.WriteLine("\nThe {0} has been sold for £{1:N0}.", this.make, this.price);
        }
    }
    class MotorCycle: Vehicle
    {
        public static int numberOfMotorC;

        public MotorCycle( string make, string model, int price, string type= "MotorCycle") : base(type, make, model, price)
        {
            numberOfMotorC++;
        }
        public void SoldMotarCycle(int price)
        {
            this.price = price;
            this.sold = true;
            numberOfMotorC--;
            totalValueInStock--;
            totalValueSold++;
            Console.WriteLine("\nThe {0} has been sold for £{1:N0}.", this.make, this.price);
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicle = new List<Vehicle>();

            Car car1 = new Car("Porsche", "718", 52800);
            Car car2 = new Car("Ferrari", "GTC4 Lusso", 229255);
            Car car3 = new Car("Honda", "Acura NSX", 143020);

            allVehicle.Add(car1);
            allVehicle.Add(car2);
            allVehicle.Add(car3);

            MotorCycle motor1 = new MotorCycle("Honda", "CRF 250", 82800);
            MotorCycle motor2 = new MotorCycle("Pocher Ducati", "Superbike 1299", 52800);
            MotorCycle motor3 = new MotorCycle("Kawasaki", "71833", 42800);

            allVehicle.Add(motor1);
            allVehicle.Add(motor3);
            allVehicle.Add(motor3);

            Vehicle.ListofVehicles(allVehicle);
            Console.WriteLine(" Total number of Vehicles : " + Vehicle.totalValueInStock);
            Console.WriteLine(" Total number of Sold Vehicles : " + Vehicle.totalValueSold);

            car1.SoldCar(52800);
            Console.WriteLine("Total number of cars:" + Car.numberOfCars);

            motor3.SoldMotarCycle(42800);
            Console.WriteLine("Total number of motors:" + MotorCycle.numberOfMotorC);

            Vehicle.ListofVehicles(allVehicle);
            Console.WriteLine("\n Total number of Vehicles : " + Vehicle.totalValueInStock);
            Console.WriteLine(" Total number of Sold Vehicles : " + Vehicle.totalValueSold);
        }
    }
}
