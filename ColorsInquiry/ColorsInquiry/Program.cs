using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColorsInquiry
{
    class Program
    {
   
        


           enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)

        {
            Console.Write(Convert.ToInt32(Days.Sat));
            Console.WriteLine(Days.Sat);

            Console.ReadKey();
            //----------------------------------------  SAMPLE OF BUILT-IN ENUM ABOVE

            //Weekdays jay = new DayOfWeek();
            Console.WriteLine("ENTER A DAY OF THE WEEK PLEASE: ");

            string entry = Console.ReadLine();

            string apply = "DayOfWeek." + entry;

           

                Console.WriteLine(DayOfWeek.Monday);// CREATION OF ELEMENT IN CLASS CONTAINING MATCHING CRITEROON
           


            //if (apply == "Tuedsay")

            //{

            //    Console.WriteLine(DayOfWeek.Tuesday);// CREATION OF ELEMENT IN CLASS CONTAINING MATCHING CRITEROON
            //}

        }
    }
}
