using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this program you will enter numbers to help you guess the data type of variable being used.");
            decimal response = 0M;
            char finished = 'N';
            char anotherGuess;

            do
            {
                //prompt the user and get the response
                Console.Write("Please type a number: ");
                response = Convert.ToDecimal(Console.ReadLine());

                //check if the number is in range for a short
                if ((response < -32768) || (response > 32767))
                {
                    Console.WriteLine("Your number is out of range for this data type.");
                }
                //check that the number isn't a decimal
                else if (response % 1 != 0)
                {
                    Console.WriteLine("This is not a decimal data type.");
                }
                else
                {
                    Console.WriteLine("This number is in the range of the data type.");
                }


                //get another guess
                Console.WriteLine("Do you want to enter another number? (Y/N) ");
                anotherGuess = Convert.ToChar(Console.ReadLine());
                finished = Char.ToUpper(anotherGuess);

            } while (finished != 'N');
        }
    }
}
