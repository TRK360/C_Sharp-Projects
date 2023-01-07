using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LlambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's review some empployees.");
           

            

            List<string> MyList1 = new List<string>() { "Joe", "Mike", "Lilly", "Sam", "Joe", "Heather", "Dale", "Pam", "Tracy", "Luke" };//creates a list with various instances of repeating strings
            Console.WriteLine("\n\nPlease type in a name to search for:\n");
            int index = 0;//initializes index as 0 (starting point of the list)
            string userinput = Console.ReadLine();//user inputs one of 3 color options (checked with boolean inspec# below)


            foreach (string color in MyList1)//loops through entire list

            {
                if (color.Contains(userinput))
                {
                    Console.WriteLine($"value of index: {index}:{color}");//returns any instance that matches approved user entry

                }
                ///while (value == userinput);// inent is to limit returned results to just red items or blue items or white items and their respective index values, but not all a the same time, just one color group per request
                index++; //moves forward





            }
        }


    }
}
