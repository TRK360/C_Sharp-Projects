using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExample
{
    public class Employee:Person
    {

        public List<int> EmpID { get; set; }
        public int eNumber { get; set; }


        public void Testingalot()

        {

            foreach (int fom in EmpID)
               
                {
                    

                    Console.WriteLine(fom);

                }


    }


    }
}
