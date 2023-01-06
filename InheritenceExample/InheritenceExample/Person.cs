using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExample
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {   
                string r = FirstName + LastName;
                
                Console.WriteLine("Name:  "+r);
                

            
                    }
    }
}
