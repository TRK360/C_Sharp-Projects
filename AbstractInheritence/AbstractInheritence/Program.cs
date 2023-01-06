using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritence
{
    class Program
    {

        static void Main(string[] args)
        {


            Employee personb = new Employee();//calling up non-abstract instance
            personb.eNumber = 176;
            personb.FirstName = "roy";
            personb.LastName = "smith";///all are enterable for use by assorted methods
            personb.SayName();// result of interactions from both class and base class
            Console.ReadLine();

           
        }
    }
    }

