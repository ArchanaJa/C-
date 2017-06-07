using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsExercise
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;
        public int numberofWheels;

        public static int numberofCars;

        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberofCars++;
        }
        public Car(string make, string model, int price,int numberofWheels)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberofCars++;
            this.numberofWheels = numberofWheels;
        }

        public void SoldCar(int price)
        {
            this.price = price;
            this.sold = true;
            Car.numberofCars--;
            Console.WriteLine("The {0} has been sold for £{1:N0}.", this.make, this.price);
        }
        
        public static void ListofAllCars(List<Car> allCars)
        {
            foreach (Car c in allCars)
            {
                Console.Write("\n Make and Model: {0}\n {1}, price: £{2:N0}.", c.make, c.model, c.price);

                if (c.sold == true)
                {
                    Console.Write("This car has been Sold \n\n");
                }
                else
                {
                    Console.Write("This car is Unsold \n\n");
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car.numberofCars = 0;
            List<Car> allCars = new List<Car>();
            //Car car1 = new Car("Porsche", "718", 42800);
            //Car car2 = new Car("Ferrari", "GTC4 Lusso", 229255);
            //Car car3 = new Car("Honda", "Acura NSX", 143020);
            //Car car4 = new Car("Reliant", "Robin", 19000, 3);

            //allCars.Add(car1);
            //allCars.Add(car2);
            //allCars.Add(car3);
            //allCars.Add(car4);

            //Console.WriteLine("Total number of cars: " + Car.numberofCars);
            //Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", car1.make, car1.model, car1.price);
            //Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", car2.make, car2.model, car2.price);
            //Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", car3.make, car3.model, car3.price);
            //Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}, Number of wheels: {3}.", car4.make, car4.model, car4.price, car4.numberofWheels);

            
            string response = "";

            do
            {
                Console.WriteLine("To add a car details, press A; To exit, press X: ");
                response = Console.ReadLine().ToLower();

                if (response == "a")
                {
                    Console.WriteLine("Please Enter the new car name: ");
                    string make = Console.ReadLine();

                    Console.WriteLine("Please Enter the new car model: ");
                    string model = Console.ReadLine();

                    Console.WriteLine("Please Enter the car price: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Car car = new Car(make, model, price);
                    allCars.Add(car);
                    Car.ListofAllCars(allCars);
                }
                        

            } while (response != "x");
        }
    }



}
           

            
            
    