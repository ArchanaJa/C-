using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averagesAssessment
{
    class Program
    {
        static List<double> numberList = new List<double>();

        static void Main(string[] args)
        {
            int userNum = 0;
            string response = " ";

            do
            {
                Console.WriteLine("Would you like to add a number to the list? (y/n):");
                response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    Console.WriteLine("Please enter a number, followed by return:");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    numberList.Add(userNum);

                }
                else if (response == "n")
                {
                    Console.WriteLine("Type ‘A’ to get the average of the list, D' to display the list, ‘S’ to sort it, or ‘X’ to exit:");
                    string ans = Console.ReadLine().ToUpper();
                    switch (ans)
                    {
                        case "A":
                            averageNum(numberList);
                            break;
                        case "D":
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                Console.WriteLine(numberList[i]);
                            }
                            break;
                        case "S":
                            numberList.Sort();
                            foreach (int x in numberList)
                            {
                                Console.WriteLine(x);
                            }
                            break;
                        case "X":
                            break;
                    }

                    //    if (ans == "A")
                    //    {
                    //        averageNum(numberList);
                    //    }
                    //   do
                    //   {
                    //    if (ans == "D")
                    //    {
                    //        for (int i = 0; i < numberList.Count; i++)
                    //        {
                    //            Console.WriteLine(numberList[i]);
                    //        }
                    //    }
                    //    if (ans == "S")
                    //    {
                    //        numberList.Sort();
                    //        foreach (int x in numberList)
                    //        {
                    //            Console.WriteLine(x);
                    //        }
                    //    }
                    //} while (ans != "X");
                }
                    
            
            } while (response != "n");

        }

       
        public static void averageNum(List<double> average)
        {
            double sum = 0;
            double total = 0;
            foreach(double s in numberList)
            {
                sum += s;
            }
            total = (double)sum / numberList.Count;

            Console.WriteLine("Average of list numbers: " + total);
           
        }
    }
}
