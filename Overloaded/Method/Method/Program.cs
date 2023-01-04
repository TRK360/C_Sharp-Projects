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

        
                Console.WriteLine("Please enter a number:");
                int n = Convert.ToInt32(Console.ReadLine());

            try
            {

                Console.WriteLine("Please enter a different number:   Optional   ");
                int p = Convert.ToInt32(Console.ReadLine()) ;


                twoField ob = new twoField();//instantiating a new callup of twoField ref

                int sum1 = ob.Add(n, p);// relying on this function arrangement

                Console.WriteLine("\nyour entry plus the other is: "
                                  + "\nResult: " + sum1);
            }
            catch (FormatException ec1)//if error due to blank, substitutes entry with 0 value
            {

                int r = 0 ;//states 0 to be added by method


                twoField ob = new twoField();//calls up new twoField ref

                int sum1 = ob.Add(n, r);

                Console.WriteLine("\nyour entry plus the other is: "
                                  + "\nResult: " + sum1);

            }


        }
    }
}
