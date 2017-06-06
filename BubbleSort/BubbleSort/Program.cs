using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = new int[10];
            Random randomNum = new Random();

            for (int i = 0; i < sortArray.Length; i++)
            {
                sortArray[i] = randomNum.Next(1, 100);
            }
            string strRan = "Random Array: ";
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                strRan += sortArray[i].ToString() + ", ";
            }
            strRan += sortArray[sortArray.Length - 1].ToString();
            Console.WriteLine(strRan);

            int temp = 0;

            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length - 1 - i; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        temp = sortArray[j + 1];
                        sortArray[j + 1] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
            }
            string strRan2 = "Sort Array: ";
            for (int i = 0; i < sortArray.Length; i++)
            {
                //Console.Write(sp[i] + " ");

                strRan2 += sortArray[i].ToString() + ", ";
            }
            strRan2 += sortArray[sortArray.Length - 1].ToString();
            Console.WriteLine(strRan2);
           // Console.ReadKey();
        }

    }
}
