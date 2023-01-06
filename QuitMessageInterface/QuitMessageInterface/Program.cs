using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QuitMessageInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                Employee personb = new Employee();//calling up non-abstract instance
                personb.eNumber = 176;
                personb.FirstName = "roy";
                personb.LastName = "smith";///all are enterable for use by assorted methods
                personb.Quit(100); 
                personb.SayName();// result of interactions from both class and base class
                Console.ReadLine();

            //Shape r1 = new Shape();

            //r1.calculateArea(100, 200);

        }
    }
}
