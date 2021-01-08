using System;

namespace SimpleCalculator
{
    class Program
    {

        

        static void Main(string[] args)

        {
            double firstNum;
            double secondNum;
            double result;
            string action;

            Console.WriteLine("\t\t\tThis is my Simple Calculator with CSharp\r");
            Console.WriteLine("\t\t\t-----------------------------------------\r\n");

            Console.WriteLine("\t\t\tEnter First Number \n");

            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an Operator (+, -, /, *, %) \n");

            action = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter Second Number \n");

            secondNum = Double.Parse(Console.ReadLine());

            if (action == "+")
            {
                result = firstNum + secondNum;
                Console.WriteLine("\t\t\tThe answer is : " + result);
            }
            else if (action == "-")
            {
                result = firstNum - secondNum;
                Console.WriteLine("\t\t\tThe answer is : " + result);
            }
            else if (action == "/")
            {
                result = firstNum / secondNum;
                Console.WriteLine("\t\t\tThe answer is : " + result);
            }
            else if (action == "*")
            {
                result = firstNum * secondNum;
                Console.WriteLine("\t\t\tThe answer is : " + result);
            }
            else if (action == "%")
            {
                result = firstNum % secondNum;
                Console.WriteLine("\t\t\tThe answer is : " + result);
            }
            else
            {
                Console.WriteLine("Operator does not exist");
            }
            Console.ReadLine();


        }
    }
}
