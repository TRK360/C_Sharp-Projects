using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {

                Console.WriteLine("Please enter a number:");
                int n = Convert.ToInt32(Console.ReadLine());



                

                Console.WriteLine("Please enter a different number:   Optional   ");
                //string p = Console.ReadLine();
                string b = Console.ReadLine();

                if (b == "")
                {

                    twoField ob = new twoField();//instantiating a new callup of twoField ref

                    int sum1 = ob.Add(n);// relying on this function arrangement (function defaults for second option here)

                    Console.WriteLine("\nyour entry plus the other is: "
                                      + "\nResult: " + sum1);
                }
                else
                { twoField ob = new twoField();//instantiating a new callup of twoField ref

                int sum1 = ob.Add(n, b);// relying on this function arrangement (function accepts second input here)

                Console.WriteLine("\nyour entry plus the other is: "
                                  + "\nResult: " + sum1);
            }



        }


        }
    }
}
