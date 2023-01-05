using System;
using System.Collections.Generic;
using System.Text;

namespace TwoResults
{
    public class HiddenMath
    {


        public int HidOb2(int numa, int numb)
        {
            int hidden = numa * 12;//not used for end-user but could be incorporated behind the scenes if ever needed

            int visible = numb;//hidden; (to test that main program receives differenet inputs properly since not being entered manually)
            return visible;
        }


        public int HidOb(int num1, int num2)
        {
            
            int hidden = num1*num2;// simple multiplication of two pre-set int values


            int trial = Convert.ToInt32(hidden);

            return trial;
        }

        public void SimpleText()
        {
            Console.WriteLine("This is a sample of how a void element in a class file can simply be called in at any moment in a main program");
        }

        public void sum(int a)
        {

            int c = a*75;//hidden math which has no entry point to main program
            Console.WriteLine("Your second Entry was   " + (a));
        }







    }
}
