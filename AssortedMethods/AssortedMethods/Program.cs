using System;

namespace AssortedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Please enter a single digit value:\n");
                int n = Convert.ToInt32(Console.ReadLine());//user input converted as req'd below
                Decimal dId = Convert.ToDecimal(n);
                string sId = Convert.ToString(n);

                numMod ob = new numMod();//referencing new instance for numMod class



                int sum1 = ob.mathOp(n, n);//applying parameters which can be used by class
                Console.WriteLine("\nyour entry plus itself: "
                                  + "\nResult: " + sum1);




                int sum2 = Convert.ToInt32(ob.mathOp(dId));//applying parameters which can be used by class
            Console.WriteLine("\nyour entry times itself 3 times: "
                                  + "\nResult: " + sum2);



                int sum3 = ob.mathOp(sId);//applying parameters which can be used by class
                int sum4 = Convert.ToInt32(sum3);// converting to applicable input format for class )(dictated by desired method)

                Console.WriteLine("\nyour entry to the power of four: "
                                  + "\nResult: " + (sum4));

            Console.ReadLine();

            }
        }
    }

