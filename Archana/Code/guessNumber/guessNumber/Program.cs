using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}
