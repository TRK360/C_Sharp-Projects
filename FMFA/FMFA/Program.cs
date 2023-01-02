using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMFA
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> MyList1 = new List<string>() { "red", "blue", "red", "white", "blue", "red", "white" };//creates a list with various instances of repeating strings
            Console.WriteLine("Please type in a color of the American flag.");
            int index = 0;//initializes index as 0 (starting point of the list)
            string userinput = Console.ReadLine();//user inputs one of 3 color options (checked with boolean inspec# below)

            bool inspect1 = userinput == "red";
            bool inspect2 = userinput == "white";
            bool inspect3 = userinput == "blue";



            if (inspect1 || inspect2 || inspect3 == true)//Tests condition of input to determine to throw error code or not
            {
                foreach (string value in MyList1)

                {
                    Console.WriteLine($"value of index: {index}:{value}");
                    index++;
                    while (value == userinput);// inent is to limit returned results to just red items or blue items or white items and their respective index values, but not all a the same time, just one color group per request

                
                }//do this in such an error
            }
            else//Continue with program
            {

                Console.WriteLine("\n\nSincerest apologies, however that color is not included.\n\n---Exiting program now.---");
                Environment.Exit(0);



            }

            Console.ReadLine();


        }








        }
    }


