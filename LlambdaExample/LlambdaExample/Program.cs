using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LlambdaExample
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Employee> MyList1 = new List<Employee>();

            MyList1.AddRange(new List<Employee>//instantiating the new list and adding objects
            {

                 new Employee { FirstName = "Lou", LastName = "Sequoia", eNumber = 10 },
                 new Employee { FirstName = "Edgar", LastName = "Holly", eNumber = 11 },
                new Employee { FirstName = "Tonya", LastName = "Conifer", eNumber = 12 },
                new Employee { FirstName = "Joe", LastName = "Atlantic", eNumber = 13 },
                new Employee { FirstName = "Kyle", LastName = "Woods", eNumber = 14 },
                new Employee { FirstName = "Alyssa", LastName = "Isle", eNumber = 15 },
                new Employee { FirstName = "Sydney", LastName = "Fox", eNumber = 16 },
                new Employee { FirstName = "Joe", LastName = "Arctic", eNumber = 17 },
                new Employee { FirstName = "Pamela", LastName = "Badger", eNumber = 18 },
                new Employee { FirstName = "Joe", LastName = "Pacific", eNumber = 19 },
                 new Employee { FirstName = "Edgar", LastName = "Holly", eNumber = 20 },
                 new Employee { FirstName = "Edgar", LastName = "Holly", eNumber = 21 }
             });

            List<Employee> trueList = MyList1.Where(x => x.eNumber > 15).ToList();///lambda function to determine those with employee ids greater than 15


                 foreach (Employee aPart in trueList)
            {
                Console.WriteLine(aPart.eNumber);//lists out results inside trueList
            }



            //List<Employee> newList = MyList1.eNumber.Where(x => x.eNumber > 15).ToList();

            List<Employee> joeList = new List<Employee>();//searching for Joe only


            foreach (Employee obj1 in MyList1)//loops through entire list



                if (obj1.FirstName == "Joe")//filtering list with if rule to add qualifying objects to a new list instantiated above

                {

                    joeList.Add(obj1);
                    Console.WriteLine(obj1.FirstName);
                }
                else { }




            if (joeList.Exists(e => e.FirstName == "Joe"))/// validation of existance lambda
            {
                Console.WriteLine("Yes, A person having a FirstName  'Joe'  exists in tthis list");
            }

            if (MyList1.Exists(e => e.eNumber > 15))/// validation of higher than 15 lambda
            {

                

                Console.WriteLine("Yes, A person as an employeeID of greater than 15");
            }
        }

            
        }

           

        }
    

