using System;

namespace Week06_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Choose a number!");

            int num = Convert.ToInt32(Console.ReadLine());
            
            
            
            int x = 0;
            while (x < num)
            {
                x++;
                if(x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
