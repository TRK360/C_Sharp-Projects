using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Example
{
    class Shape
    {

        public void calculateArea(int l, int b)/// inegers match callup requirement in IPolygon Interface
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);

        }
    }
}