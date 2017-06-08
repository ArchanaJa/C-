using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class Vehicle
    {
        public virtual void totalWheels()
        {
            Console.WriteLine("A Truck has 0 wheels");
        }
    }
    class BiCycle : Vehicle
    {
        public override void totalWheels()
        {
            Console.WriteLine("A Bicycle has 2 wheels");
        }
    }
    class Car: Vehicle
    {
        public override void totalWheels()
        {
            Console.WriteLine("A Car has 4 wheels");
        }
    }
    class Truck: Vehicle
    {
        public new void totalWheels()
        {
            Console.WriteLine("A Truck has 18 wheels");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new BiCycle());
            vehicles.Add(new Car());
            vehicles.Add(new Truck());

            foreach(Vehicle v in vehicles)
            {
                v.totalWheels();
            }
            Truck truck1 = new Truck();
            truck1.totalWheels();
        }
    }
}
