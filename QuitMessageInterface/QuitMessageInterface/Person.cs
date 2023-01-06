using System;
using System.Collections.Generic;
using System.Text;

namespace QuitMessageInterface
{

    public abstract class Person///abstract to retain/preserve parameters (person is too general, types of persons would be employee, customer, owner, etc.)
    {

        public string FirstName { get; set; }//receivable parameters
        public string LastName { get; set; }


        public abstract void Append();

        public virtual void SayName() //this function produces addable input to output of Employee class to Main Program (remember, Employee class is not Abstract)
        {


            string res = FirstName + "  " + LastName;
            Console.WriteLine("\nAs a result of the SayName method, \nthe name on record is:  \n\n--" + res + "--");
        }
    }
}