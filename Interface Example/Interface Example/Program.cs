using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Shape r1 = new Shape();

            r1.calculateArea(100, 200);//supplying calculation factors to Shape, which is bouncing these off the Interface IPolygon


        }
    }
}
