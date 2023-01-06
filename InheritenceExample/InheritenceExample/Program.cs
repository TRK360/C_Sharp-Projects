using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace InheritenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Person personr = new Person();
            
            
            //personr.SayName();
            //Console.ReadLine();

            Employee personb = new Employee();
            personb.eNumber = 1;
            

            

            personr.FirstName = "Sample ";
            personr.LastName = "Student";
            personr.SayName();




        }
    }
}
