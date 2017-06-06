using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];

            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return after each: ");
            Console.WriteLine("Please enter a 1st number: ");
            numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a 2nd number: ");
            numbers[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a 3rd number: ");
            numbers[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a 4th number: ");
            numbers[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a 5th number: ");
            numbers[4] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Thank you for entering 5 numbers\n");

            double add = 0;

            for(int i=0; i < numbers.Length; i++)
            {
                 add+= numbers[i];
            }
            //Console.WriteLine(add);

            double average = add / numbers.Length;

            Console.WriteLine("The sum of all numbers: " + add);
            Console.WriteLine("The average of all numbers: " + average);




            double[,] twoDimensionArray = new double[5, 5];

            for (int i = 0; i < twoDimensionArray.GetLength(0); i++)
            {

                for (int j = 0; j < twoDimensionArray.GetLength(1); j++)
                {
                    
                }
            }
            double sum = 0;
            for (int i=0; i<twoDimensionArray.GetLength(0); i++)
            {
                
                for(int j=0; j<twoDimensionArray.GetLength(1); j++)
                {
                    sum += twoDimensionArray[i,j];
                }
            }
            Console.WriteLine("The sum of arrays: " + sum);


        }
    }
}
