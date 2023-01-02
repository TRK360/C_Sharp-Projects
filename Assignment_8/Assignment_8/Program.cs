using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                List<int> numbers = new List<int>() { 14, 29, 57, 79, 89, 107 };
                Console.WriteLine("Please enter a number to which a pre-made list will be divided by.");
                int index = 0;//initializes index as 0 (starting point of the list)
                int userinput = Convert.ToInt32(Console.ReadLine());//user inputs number, string must be convtd to int

                foreach (int num in numbers)// identifying to loop through each instance in the list

                {
                    Console.WriteLine($"result of index spot: {index}:{num / userinput}");//produces result
                    index++;//moves index forward until list runs out of options


                }
            }



    catch (FormatException Prob1) // in instance where letter or character besides number is entered
            {Console.WriteLine("Sincerest Apologies, Please enter a numerical value (IE  22)");//custom error message.
        
        }

            finally 
            {
                Console.WriteLine("\n\nThis is the conclusion of the program, whichever path you chose...\n\n\n");// ocurrs whether errors occurred or not
                

            }

        }
    
    }

}