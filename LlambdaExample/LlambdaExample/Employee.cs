using System;
using System.Collections.Generic;
using System.Text;

namespace LlambdaExample
{
    public class Employee
    {

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int eNumber { set; get; }
        public bool IsManager { set; get; }

        //public int fNumber { get; set; }///receivable input at time of logging a specific type of person (person is abstract)




        
        public void myResponse()
        {

            Console.WriteLine(eNumber);

        }




}
    }
