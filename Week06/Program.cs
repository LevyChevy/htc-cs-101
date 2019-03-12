using System;

namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Enter a number: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            Console.Writeline(factorial(userInput));
        }

        public static int factorial(int number)
        {
            int total = 1;
            while (number > 0)
            {
                total *= number;
                number--;
            }
            return total;
        }
    }
}
