using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassObjectExercise
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public bool sold; 

        public static int numberofCars;
        public static int numberOfSales;

               
        public void AddCar(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberofCars++;

        }

        public void SoldCar(int price)
        {
            this.price = price;
            this.sold = true;
            Car.numberofCars--;
            Car.numberOfSales++;
            //Console.WriteLine("The {0} has been sold for £{1:N0}.", this.make, this.price);
        }
        public void ListCar()
        {
            Console.Write("\n Make and Model: {0} {1}, price: £{2:N0}.", this.make, this.model, this.price );

            if (sold == true)
            {
                Console.Write("This car has been Sold \n\n");
            }
            else
            {
                Console.Write("This car is Unsold \n\n");
            }
        }

        public static void ListofAllCars(List<Car>allCars)
        {
           foreach(Car c in allCars)
            {
                Console.Write("\n Make and Model: {0} {1}, price: £{2:N0}.", c.make, c.model, c.price);

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
            //List<Car> allCars = new List<Car>();

            //Car.numberofCars = 0;

            //Car car1 = new Car();
            //car1.make = "Rolls Royce";
            //car1.model = "Silver Cloud";
            //car1.price = 35000;
            //Car.numberofCars++;

            //Car car2 = new Car();
            //car2.make = "BMW";
            //car2.model = "318";
            //car2.price = 25000;
            //Car.numberofCars++;

            //Car car3 = new Car();
            //car3.make = "Audi";
            //car3.model = "Q7";
            //car3.price = 45000;
            //Car.numberofCars++;

            //car.Add(car1);                             //using list
            //car.Add(car2);                            //using list 
            //car.Add(car3);

            //Console.WriteLine("Total number of cars in stock is : " + Car.numberofCars);

            //foreach (Car c in car)
            //{
            //    Console.WriteLine("The details of this car are: " + c.make + ", " + c.model + ", " + c.price + "\n");
            //}
            //Console.WriteLine("The details of this car are: " + myCar.make + ", " + myCar.model + ", " + myCar.price + ", " + myCar.sold);
            //Console.WriteLine("The details of this car are: " + myCar1.make + ", " + myCar1.model + ", " + myCar1.price);
            //Console.WriteLine("The details of this car are: " + myCar2.make + ", " + myCar2.model + ", " + myCar2.price);

            //Console.WriteLine("Make and Model: {0} {1}, price: £{2:N0}.", car1.make, car1.model, car1.price);       //one more format for display output

            List<Car> allCars = new List<Car>();
            Car.numberofCars = 0;
            Car.numberOfSales = 0;

            Car car1 = new Car();
            car1.AddCar("Rolls Royce", "Silver Cloud", 45000);
            Car car2 = new Car();
            car2.AddCar("BMW", "3 Series", 35000);
            Car car3 = new Car();
            car3.AddCar("Audi", "Q7", 55000);
            Car car4 = new Car();
            car4.AddCar("Ferrari", "458", 255000);

            allCars.Add(car1);
            allCars.Add(car2);
            allCars.Add(car3);
            allCars.Add(car4);

            Car.ListofAllCars(allCars);
            Console.WriteLine(" Total number of Cars : " + Car.numberofCars);
            Console.WriteLine(" Total number of Sales : " + Car.numberOfSales);

            car2.SoldCar(35000);
            Console.WriteLine();
            

            //car1.ListCar();
            //car2.ListCar();
            //car3.ListCar();
            Car.ListofAllCars(allCars);
            Console.WriteLine(" Total number of Cars: " + Car.numberofCars);
            Console.WriteLine(" Total number of Sales : " + Car.numberOfSales);

           // Console.ReadKey();
        }
        
    }
}
