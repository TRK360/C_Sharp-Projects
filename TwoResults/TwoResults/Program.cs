using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TwoResults
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter one SINGLE DIGIT number followed by a second...(PRESS ENTER TO SUBMIT EACH NUMBER (4 KEYSTROKES TOTAL)");
            int uEntry1 = Convert.ToInt32(Console.ReadLine());//user inputs first value to apply
            int uEntry2 = Convert.ToInt32(Console.ReadLine());//user inputs second value to apply

            Console.WriteLine("Input accepted!\n\n---PROCEEDING WITH PROGRAM---");

            HiddenMath ob = new HiddenMath();// calls up class and inherent method

            /////int sum1 = ob.HidOb2(uEntry1, uEntry2);//called up to produce result

            /////Console.WriteLine("Although there are some additional math results available, we are only passing along the following: " + sum1 + "\n\n---PROCEEDING TO FINAL PART OF PROGRAM---");

            Console.ReadLine();


            Console.WriteLine("Please observe below to witness a pre-set named parameter value times another one:");/// beginning portion where pre-named parameters are manually assigned values

            int y = uEntry1;//setting integers to later be modified
            int z = uEntry2;

            Console.WriteLine("PRE-SELECTED inputs accepted!\n\n---PROCEEDING WITH PROGRAM---");

            //HiddenMath ob = new HiddenMath();// testing point: calling up class and inherent method

            ob.HidOb(y=13, z=10);// assigning values to parameters x and y
            int sum2 = ob.HidOb(y,z);//applying method with inputs specified above

            Console.WriteLine("The PRE-SELECTED inputs multiplied by one another is:    "+sum2+ "\n\n---ENDING PROGRAM NOW---");

            Console.ReadLine();

            HiddenMath ex = new HiddenMath();
            ex.SimpleText();//executing a string callup without specifying type 
            ex.sum(uEntry2);


        }
    }
}
