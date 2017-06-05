using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The candidates for the presidency of USA are: Donald Trump, Hillary Clinton, Ben");
            string ychoice = Console.ReadLine().ToLower();

            string msg = " ";

            switch (ychoice)
            {
                case "donald":
                    msg = "Not good choice";
                    break;
                case "hillary":
                    msg = "Good Choice";
                    break;
                case "Ben":
                    msg = "Bad Choice";
                    break;
                default:
                    msg = "please enter valid name";
                    break;
            }
            Console.WriteLine(msg);
        }
    }
}
