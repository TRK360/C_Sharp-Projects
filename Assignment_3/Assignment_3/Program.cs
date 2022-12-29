using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to an Insurability Verification Program---");

            Console.WriteLine("Question 1:  What is your age");
            string AYrs = Console.ReadLine();
            int Age = Convert.ToInt32(AYrs);//uses string data only

            Console.WriteLine("Question 2:  Have you ever had a DUI/DWI? \n(true or false)");
            string DOffense = Console.ReadLine();
            Boolean OStatus = Convert.ToBoolean(DOffense);//uses string data from readline input and convets to boolean
            Boolean OStatus_opp = !OStatus;//simplifies later needed use of && to produce proper end result at final console writeline

            Console.WriteLine("Question 3:  How many speeding tickets do you have on your record within the past five years?");
            string STickets = Console.ReadLine();
            int QTickets = Convert.ToInt32(STickets);//uses string data only
            //Console.WriteLine(Age+"\n"+OStatus + "\n"+QTickets);//tests proper interpretation of above lines

            Boolean Analysis = (Age>=16 && OStatus_opp && QTickets<=3);

            Console.WriteLine("It is: "+Analysis+" that you are insurable");
        }
    }
}
