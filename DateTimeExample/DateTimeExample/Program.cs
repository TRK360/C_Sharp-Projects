using System;
using System.IO;
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks; 

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fourth Dimensional Figure\n\nPlease Enter A number:");

            int C = Convert.ToInt32(Console.ReadLine());
            DateTime d1 = DateTime.Now;/// calls in current date and time
            DateTime d2 = d1.AddHours(C);///creates a condition in the future to display the time of

            System.Console.WriteLine("Upon execution of this code, the current DateTime = \n\n{0:dd} {0:y}, {0:t} ", d1);//formatting important
            System.Console.WriteLine("New DateTime (After adding hours) = {0:dd} {0:y}, {0:t} ", d2);


        }
    }
}
