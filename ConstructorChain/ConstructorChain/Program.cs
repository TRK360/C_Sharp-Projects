using System;

namespace ConstructorChain
{
    
       class mClass
        {
            public mClass()/// each declared class ahead of actual program is developed with constructors with chained classes per below
            {
                Console.WriteLine("ONE");
            }

            public mClass(int x) : this()
            {
                Console.WriteLine("TWO");
            }

            public mClass(int x, int y) : this(100)
            {
                Console.WriteLine("TWO AND A HALF....");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                mClass c = new mClass(100, 20);//instantiates a new object which begins leaning on the constructors in the classes above
                Console.Read();
            
       
            const string units = "SF";// string constant Units is a good candidate for a const
            var area = "150"; //implicit reference to string

            Console.WriteLine("The square footage value of a space 15 ft x 10 ft will always be:  " + area + "  " + units);


        }
    }
}
