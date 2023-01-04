using System;
using System.Collections.Generic;
using System.Text;

namespace AssortedMethods
{
    class numMod
    {
        // applyingtwo integer values.
        public int mathOp(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // applying three decimal values.
        public int mathOp(Decimal a)
        {
            int sum = Convert.ToInt32((a * a * a));
            return sum;
        }

        // adding string and converting to integer to return as a string result.
        public int mathOp(string a)
        {
            int b = Convert.ToInt32(a);
         
            int reSum = b*b*b*b;

            return reSum;
        }

    }
}
