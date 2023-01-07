using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoubleEqualsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new Employee();///enter employee1 details here
            emp1.Id = 1;
            emp1.FirstName = "Bob";// helpful for different a alysis, not for this demo
            emp1.LastName = "Smith";// helpful for different a alysis, not for this demo

            Employee emp2 = new Employee();///enter employee1 details here
            emp2.Id = 1;/// intentionally same as above (if changed, booean results will change)
            emp2.FirstName = "Bob";
            emp2.LastName = "Smith";


            if (emp1 == emp2)// properties/method for employee comparison
            {

                Console.WriteLine("these cats and kittens are IDENTICAL");

            }

            else
            {
                Console.WriteLine("these individuals are all UNIQUE");
            }

            Console.ReadLine();





        }
    }
}
