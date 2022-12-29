using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to PACKAGE EXPRESS.  Please follow instructions below.---\nPlease enter the package information per items below:\n\n\nPackage Weight (in lbs):\n");  
            int Weight = Convert.ToInt32(Console.ReadLine());//uses req'd string data then converts to integer

            Boolean WtChk = (Weight > 50);

            string Progress = Convert.ToString(WtChk);//uses boolean data then converts to req'd string

            if (Progress == "True") { Console.WriteLine("Sincerest apologies, however your package is too heavy to ship with Package Express.\n\n---Exiting program now.---");
                Environment.Exit(0);
            }
            else { Console.WriteLine("\n\nPlease proceed by entering the following additional details:");}



            Console.WriteLine("\n\nPackage Width (in cm):\n");
            int Width = Convert.ToInt32(Console.ReadLine());//uses req'd string data then converts to integer

            Console.WriteLine("\n\nPackage Height: (in cm):\n");
            int Height = Convert.ToInt32(Console.ReadLine());//uses req'd string data then converts to integer

            Console.WriteLine("\n\nPackage Length: (in cm):\n");
            int Length = Convert.ToInt32(Console.ReadLine());//uses req'd string data then converts to integer

            decimal SubTotal = ((Height * Width * Length * Weight)/100);//uses integer values and divides them to a reasonable sum for decimal application

            Console.WriteLine("The total estimated shipping cost for this package is:  $"+SubTotal+".00\n\nThank you!");

            ///Console.WriteLine("\n\n\n" + Weight +"\n"+Width+"\n"+Height + "\n"+Length+"\n" + WtChk);//tests proper interpretation of above lines

        }
    }
}
