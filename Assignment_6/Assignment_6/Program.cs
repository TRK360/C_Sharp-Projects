using System;
using System.Collections.Generic;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_one = new int[] { 33, 44, 55, 66, 77, 88, 99, 37, 48, 59 };//Manual Array
            int listLgth1 = array_one.Length - 1;//0 is the first element of an array, taking 1 out will result in correct info provided to user in prompt
            Console.WriteLine("Please a number from 0 to " + listLgth1 + ".");
            int Rep1 = Convert.ToInt32(Console.ReadLine());

            if (Rep1 > listLgth1)//Tests condition of input to determine to throw error code or not
            {
                Console.WriteLine("\n\nSincerest apologies, however you're unable to proceed.\n\n---Exiting program now.---");
                Environment.Exit(0);
            }//do this in such an error

            else//Continue with program
            {

                Console.WriteLine("\n\nYour integer driven search result is: " + array_one[Rep1]);

                string[] array_two = new string[] { "cat", "dog", "fish", "bunny", "jerbal", "turtle" };//Manual string array
                int listLgth2 = array_two.Length - 1;//0 is the first element of an array, taking 1 out will result in correct info provided to user in prompt
                Console.WriteLine("\n\nPlease a number from 0 to " + listLgth2 + " to reveal a common household pet.");


                int Rep2 = Convert.ToInt32(Console.ReadLine());

                if (Rep2 > listLgth2)//Tests condition of input to determine to throw error code or not
                {
                    Console.WriteLine("\n\nSincerest apologies, however you're unable to proceed.\n\n---Exiting program now.---");
                    Environment.Exit(0);
                }//do this in such an error

                else//Continue with program
                {
                    Console.WriteLine("\n\nYour integer driven search result is: " + array_two[Rep2]);

                    List<string> MyList1 = new List<string>();//Listed string items
                    MyList1.Add("Algeria");
                    MyList1.Add("Argentina");
                    MyList1.Add("Canada");
                    MyList1.Add("England");
                    MyList1.Add("Egypt");
                    MyList1.Add("France");
                    MyList1.Add("Ireland");
                    MyList1.Add("Norway");
                    MyList1.Add("Spain");
                    MyList1.Add("Switzerland");

                    int listLgth3 = MyList1.Count - 1;//0 is the first element of an array, taking 1 out will result in correct info provided to user in prompt

                    Console.WriteLine("\n\nPlease a number from 0 to " + listLgth3 + " to view Countries on the list.");

                    int Rep3 = Convert.ToInt32(Console.ReadLine());

                    if (Rep3 > listLgth3)//Tests condition of input to determine to throw error code or not
                    {
                        Console.WriteLine("\n\nSincerest apologies, however you're unable to proceed.\n\n---Exiting program now.---");
                        Environment.Exit(0);
                    }//do this in such an error

                    else
                    {


                        Console.WriteLine("\n\nYour Answer is: " + MyList1[Rep3]);
                        Console.ReadLine();//pauses program before closeout

                    }
                }
            }
        }
    }
}
