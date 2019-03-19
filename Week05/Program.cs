using System;

namespace Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?!");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?!");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what operation do you want?");
            string operation = Console.ReadLine();

            if(operation == "+")
            {
               Console.WriteLine(AddNumbers(firstNum, secondNum));
            }
            else if(operation == "-")
            {
                int difference = SubbtractNumbers(firstNum, secondNum);
                Console.WriteLine(difference);
            }
            else if(operation == "*")
            {
                int product = MultiNumbers(firstNum, secondNum);
                Console.WriteLine(product);
            }
            else if(operation == "/")
            {
                int quotent = DivideNumbers(firstNum, secondNum);
                Console.WriteLine(quotent);
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubbtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int MultiNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

         public static int DivideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

         public static double QuadNumbers(double a, double b, double c)
        {
            return  -b + ;
        }

    }
}
