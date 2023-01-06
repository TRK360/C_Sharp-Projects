using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExample
{
    public class Person
    {

        public List<string> FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {   foreach (string nom in FullName)
            {
                string r = FirstName + LastName;
                
                Console.WriteLine(r);
                

            }
                    }
    }
}
