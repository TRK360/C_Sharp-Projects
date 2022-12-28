using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report\nQuestion 1:  Please enter your first name");//notes example
            string Fname = Console.ReadLine();//uses string data only
            Console.WriteLine("Question 2:  Which course are you currently studying?");
            string CCourse = Console.ReadLine();//uses string data only
            Console.WriteLine("Question 3:  What is the current page number of the "+CCourse+" part of the program?");
            string CPage = Console.ReadLine();//uses string data only, readout will only need string, no need to convert it to integer
            Console.WriteLine("Question 4:  Do you need any assistance with any subject of the " + CCourse + " part of the program?\n(Please enter true or false)");
            string Help_r = Console.ReadLine();
            Boolean Help_r2 = Convert.ToBoolean(Help_r);//uses string data from readline input and convets to boolean
            Console.WriteLine("Question 5:  If applicable, Please describe any positive experiences today with the " + CCourse + " part of the program?");
            string CFeedback = Console.ReadLine();//uses string data only
            Console.WriteLine("Question 6:  Is there any other feedback that you would like to provide?");
            string OFeedback = Console.ReadLine();//uses string data only
            Console.WriteLine("Question 7:  How many Hours of study did you complete today?");
            string CHrs = Console.ReadLine();
            int Hrs = Convert.ToInt32(CHrs);//uses string data only
            Console.WriteLine("Thank you for your responses, an instructor will review and respond.  \n---THIS IS THE PROGRAM END---  \nHave a nice day.");
            //Console.WriteLine("All inpusts received so far:\n" + Fname+ " \n" + CCourse + " \n"+ CPage + " \n" + Help_r2 + " \n" + CFeedback + " \n" + OFeedback + " \n"+Hrs);// this is a test item to validate that all end results are able to be used properly
            Console.ReadLine();
           

        }
    }
}
