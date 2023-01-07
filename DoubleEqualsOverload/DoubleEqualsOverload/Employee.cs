using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleEqualsOverload
{
    public class Employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }




        //public bool Equals(Employee other)
        //{
        //    throw new NotImplementedException();

        //}


        public static bool operator ==(Employee emp1, Employee emp2)///uses == operator to compare integer inputs and return a boolean
        {
            if (emp1.Id.Equals(emp2.Id))
            {
                return true;/// boolean reaction

            }
            return false;  /// alt boolean reaction if unequal in value
        }

        public static bool operator !=(Employee emp1, Employee emp2)///needed offset or pair to above == analysis
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
                return true;

            }
            return false;


        }

        


    }
}
