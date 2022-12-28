using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson One:\nPlease enter your hourly rate.   (IE '10.75')");
            string HWg1 = Console.ReadLine();
            int Wgs1 = Convert.ToInt32(HWg1);//uses string data only
            Console.WriteLine("Please enter your hours worked per week.   (IE '36.25')");
            string WHrs1 = Console.ReadLine();
            int Hrs1 = Convert.ToInt32(WHrs1);//uses string data only

            Console.WriteLine("---TRANSITIONING INPUT---\nPerson Two:\nPlease enter your hourly rate.   (IE '10.75')");
            string HWg2 = Console.ReadLine();
            int Wgs2 = Convert.ToInt32(HWg2);//uses string data only
            Console.WriteLine("Please enter your hours worked per week.   (IE '36.25')");
            string WHrs2 = Console.ReadLine();
            int Hrs2 = Convert.ToInt32(WHrs2);//uses string data only


            int p1Hrs = Hrs1;//converts to integers for math below
            int p1Wgs = Wgs1;//converts to integers for math below
            int wpy = 52;//controls how many weeks per year are calculated
            int combined1 = p1Hrs * p1Wgs*wpy;//multiplication op
            int p2Hrs = Hrs2;
            int p2Wgs = Wgs2;
            int combined2 = p2Hrs * p2Wgs*wpy;//multiplication op
            Boolean Analysis = combined1 > combined2;//True or False analysis

            Console.WriteLine("The annual income of Person 1 is:  \n" + combined1+"\n \n" + "The annual income of Person 2 is: \n" + combined2);

            Console.WriteLine("\n\nDoes Person 1 make more annually than Person 2?\nThe answer is:  " + Analysis);



        }
    }
}
