using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerSampleClass_Methods
{
    public class ClassM
    {

        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Multiply(int a, int b, int c)
        {
            int sum = a * b * c;
            return sum;
        }

        // adding four integer values.
        public int Power4(int a, int b, int c, int d)
        {
            int sum = a^4;
            return sum;
        }


    }
}
