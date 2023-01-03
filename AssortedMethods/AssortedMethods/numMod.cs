using System;
using System.Collections.Generic;
using System.Text;

namespace AssortedMethods
{
    class numMod
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public Decimal Multiply(Decimal a)
        {
            int sum = Convert.ToInt32((a * a * a));
            return sum;
        }

        // adding four integer values.
        public string Power4(string a)
        {
            int b = Convert.ToInt32(a);
         
            string reSum = Convert.ToString(b*b*b*b);
            return reSum;
        }

    }
}
