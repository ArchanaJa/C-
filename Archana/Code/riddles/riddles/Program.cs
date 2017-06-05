using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddles1 = "for cross a road";
            string riddles2 = "shark-infested custard";
            string yAns1 = "";
            string yAns2 = "";

            int numGuess = 0;
            int nrGuess = 0;

            do
            {
                Console.WriteLine("I have a got a riddle for you. Why did the chicken cross the road?");
                yAns1 = Console.ReadLine();

                if (yAns1 == "I give up")
                {
                    Console.WriteLine("The correct answer is: for cross a road \n");                    
                }

                else
                {
                    if (yAns1 != riddles1)
                    {
                        numGuess++;
                        Console.WriteLine("wrong answer \n");
                        Console.WriteLine("for correct answer just type 'I give up'...");
                    }
                    else
                    {
                        nrGuess++;
                        Console.WriteLine("Yah!! You got a right answer\n");
                    }

                }


            } while ((yAns1 != riddles1) && (numGuess < 3));


            nrGuess = 0;

            while ((yAns2 != riddles2) && (numGuess < 3))
            {
                Console.WriteLine("I have a got another riddle for you. Why yellow and dangerous?");
                yAns2 = Console.ReadLine();

                if (yAns2 == "I give up")
                {
                    Console.WriteLine("The correct answer is: shark-infested custard");
                   
                }
                else if (yAns2 == riddles2)
                    {
                        nrGuess++;
                        Console.WriteLine("Yah!! You got a right answer");
                    }
                    else
                    {
                        numGuess++;
                        Console.WriteLine("wrong answer\n");
                        Console.WriteLine("for correct answer just type 'I give up'...") ;                   
                   }
            }

            Console.WriteLine("You got right answers of riddles" + nrGuess + "out of 2");
        }
    }
}
