using System;

namespace AssortedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Please enter a single digit value:\n");
                int n = Convert.ToInt32(Console.ReadLine());
                Decimal dId = Convert.ToDecimal(n);
                string sId = Convert.ToString(n);

                numMod ob = new numMod();

                int sum1 = ob.Add(n, n);
                Console.WriteLine("\nyour entry plus itself: "
                                  + "\nResult: " + sum1);


                int sum2 = Convert.ToInt32(ob.Multiply(dId));
                Console.WriteLine("\nyour entry times itself 3 times: "
                                  + "\nResult: " + sum2);

                string sum3 = ob.Power4(sId);
                int sum4 = Convert.ToInt32(sum3);

                Console.WriteLine("\nyour entry to the power of four: "
                                  + "\nResult: " + (sum4));
            }
        }
    }

