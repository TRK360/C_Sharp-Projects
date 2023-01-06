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
            personb.EmpID = new List<int>() {1};
            personb.Testingalot();

            personr.FullName = new List<string>() { "" };

            personr.FirstName = "Sample ";
            personr.LastName = "Student";
            personr.SayName();




        }
    }
}
