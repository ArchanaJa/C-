using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random random = new Random();


            //Console.WriteLine("Hello, world!");

            // Console.WriteLine("Please Enter a number: ");
            // i = Convert.ToInt32(Console.ReadLine());

            //// var randomNum =Math.Round(Math. * 10);

            // if(a < i)
            // {
            //     Console.WriteLine("the number is less than the one I am thinking..");
            // }
            // if(a > i)
            //     {
            //         Console.WriteLine("the number is greater than the one I am thinking..");
            //     }
            // else
            // {
            //     Console.WriteLine("your guess is right..");
            // }



     //// //-------do while loop------------//


            int guess = 0;
            Random random = new Random();
            int myNumber = random.Next(1, 10);
            Console.WriteLine("enter the number:");

            int b = 0;
            do
            {

                guess = Convert.ToInt32(Console.ReadLine());
                if (myNumber == guess)
                {
                    Console.WriteLine("your guess is right..");
                }
                else if (myNumber < guess)
                {
                    Console.WriteLine("the number is less than the one I am thinking..");
                }
                else
                {
                    Console.WriteLine("the number is greater than the one I am thinking..");
                }

                b++;
            } while (guess != myNumber);


            /////-----Switch loop----------------------//

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
