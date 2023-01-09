using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColorsInquiry
{
    class Program
    {

        public class ParseTest
        {
            [Flags]
            enum Days { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };



            public static void Main() { 

        try{            
            
                Console.WriteLine("Please Enter a day of the week.");

                string wDay = Console.ReadLine();// String input to later parse

                int index = 0;

                foreach (string Weekday in Enum.GetNames(typeof(Days)))/// searching all string items in Enum Days

                {

                    if (Weekday == wDay)
                    {

                        Console.WriteLine("{0} = {1:D}", Weekday, Enum.Parse(typeof(Days), Weekday));//parses content in enum to string to return to Writeline in proper format

                    }
                    else { }
                    index++;
                }

            

            Console.WriteLine("just checking...");
            }
      catch (FormatException Prob1) // in instance where letter or character besides number is entered
            {Console.WriteLine("Sincerest Apologies, Please enter a properly spelled weekday (IE  Thursday)");//custom error message.
        
        }
    }
         
           
        }
    }
}

