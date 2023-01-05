using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Property_Methods
{
    public class Display///everything here is public and in need of input

    {

        public int Displayz(int s)//instance 1
        //need to assign value
        {
            int b = s;
            //a += a;
            int sum3 = b + 7;
            return sum3;
        }

        public int Displayz(int u, int t)//instance 2 for overload
        //need to assign value
        {
            int b = u*t;
            //a += a;
            int sum4 = b + 100;
            return sum4;
        }

        public int Vet(int z)

        {
            int a = z;
            int b = a/2;
            return b; }


        public void SimpleText()
        {
            Console.WriteLine("Geeks");
        }

        public void sum(int a, int b)
        {
            Console.WriteLine(".\n\n Result: " + (a * b));
        }





    }
}

