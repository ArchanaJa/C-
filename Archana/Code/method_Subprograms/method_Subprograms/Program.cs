using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Subprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
        

            Console.Write("Please enter a 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            double result1 = Add(num1, num2);
            double result2 = Subtract(num1, num2);
            double result3 = Multiply(num1, num2);
            double result4 = Division(num1, num2);
            double result5 = calculatePower(Convert.ToDouble(num1), Convert.ToDouble(num2));
            //double result6 = calculateReciprocal(Convert.ToDouble(num1));

            Console.WriteLine("Please enter the sign r, s, t, c:");
            char sign = Convert.ToChar(Console.ReadLine());
            double result6 = calcMathOperators(num1, sign);



            Console.Write("Addition of numbers :" + result1 + "\n\n");
            Console.Write("Subtraction of numbers :" + result2 + "\n\n");
            Console.Write("Multiplication of numbers :" + result3 + "\n\n");
            Console.Write("Division of numbers :" + result4 + "\n\n");
            Console.Write("power of numbers :" + result5 + "\n\n");
            Console.Write("calculation of :" + sign + " " + num1 + " " + "is " + result6 + "\n\n");
        }

        static double Add (int firstNumber, int secondNumber)
        {
            double total = 0;
            total = firstNumber + secondNumber;
            return total;
        }
        static double Subtract(int firstNumber, int secondNumber)
        {
            double total=0;
            total = firstNumber - secondNumber;
            return total;
        }
        static double Multiply(int firstNumber, int secondNumber)
        {
            double total=0;
            total = firstNumber * secondNumber;
            return total;
        }
        static double Division(double firstNumber, double secondNumber)
        {
            double total = 0;
            total = firstNumber / secondNumber;
            return total;
        }
        static double calculatePower(double firstNumber, double secondNumber)
        {
            double power = Math.Pow(firstNumber, secondNumber);
            return power;
            
        }
        static double calculateReciprocal(double firstNumber)
        {
            double power = 1 / firstNumber;
            return power;

        }
        static double calcMathOperators(double firstNumber, char sign)
        {
            double result = 0;
            switch (sign)
            {
                case 'r':
                    result = 1 / firstNumber;
                    break;
                case 's':
                    result = Math.Sin(firstNumber);
                    break;
                case 'c':
                    result = Math.Cos(firstNumber);
                    break;
                case 't':
                    result = Math.Tan(firstNumber);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;

        }
    }
}
