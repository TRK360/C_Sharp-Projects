using System;
using System.Collections.Generic;
using System.Text;




namespace Method
{
    public class twoField
    {

        // adding two integer values.
        public int Add(int n, string b = "") 
        {
            
            if (b != ""){


            int f = Convert.ToInt32(b);

            int sum2 = n + f;

                return sum2;
            }

            int sum = n + 0;
            return sum;

        }



    }
}
