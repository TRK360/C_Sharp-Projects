using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'a';// declaring an initialization of variable x

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 'f');//sets boundry for writeline function to stop executing for do-while statement


            Console.WriteLine("Please enter a value between 1 and 10");//seeks user input
            int n = Convert.ToInt32(Console.ReadLine());
            while (++n < 11)//sets boundry for while statement
            {
                Console.WriteLine("Newest value of n is {0}", n);//monitorable activity
            }
        }
    }
}
