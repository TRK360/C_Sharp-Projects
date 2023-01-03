using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntegerSampleClass_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a single digit value:\n");
            int n = Convert.ToInt32(Console.ReadLine());

            ClassM ob = new ClassM();

            int sum1 = ob.Add(n, n);
            Console.WriteLine("your entry plus itself: "
                              + "\nResult: " + sum1);

            int sum2 = ob.Multiply(n, n, n);
            Console.WriteLine("your entry times itself 3 times: "
                              + "\nResult: " + sum2);
            int sum3 = ob.Power4(n, n, n, n);
            Console.WriteLine("your entry to the power of four: "
                              + "\nResult:: " + sum3);
        }
    }
}
