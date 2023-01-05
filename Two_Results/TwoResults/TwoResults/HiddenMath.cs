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









    }
}
