using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            double result = 0;

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            Console.WriteLine("enter your FIRST number - ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("enter your SECOND number - ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("add " + firstNumber + " and " + secondNumber);
            Console.WriteLine("subtract " + secondNumber + " from " + firstNumber);
            Console.WriteLine("multiply " + firstNumber + " and " + secondNumber);
            Console.WriteLine("divide " + secondNumber + " by " + firstNumber);
            Console.WriteLine("enter your option for the numbers - ");

            string option = Console.ReadLine();

            // Use methods for each type of calculation.
            if (option == "add")
            {
                result = Add(firstNumber,secondNumber);
            }
            else if (option == "subtract")
            {
                result = Subtract( firstNumber,secondNumber);
            }

            else if (option == "multiply")
            {
                result = Multiply(firstNumber, secondNumber);
            }
            else if (option == "divide")
            {
                result = Divide(firstNumber, secondNumber);
            }

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }

        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>sum</returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        /// <summary>
        /// subtracts second number from first number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>result</returns>
        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>returns product of two numbers</returns>
        public static double Multiply (double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        /// <summary>
        /// divides firstNumber by the second number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>returns quotient</returns>
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
