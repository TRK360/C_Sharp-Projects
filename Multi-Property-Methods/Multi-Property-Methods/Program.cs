﻿using System;



namespace Multi_Property_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number to see half of its value:");
            Display ob = new Display();


            int j = Convert.ToInt32(Console.ReadLine());//receives user input
            int sum6 = ob.Vet(j);//calls up method
            Console.WriteLine(sum6);

////--------------------------------------


            int s = 4;

                int sum3 = ob.Displayz(s);
                
                Console.WriteLine("Value of pre-determined input and result of predetermined function equals: {0}\n\nPRESS ENTER TO CONTINUE", sum3);//demonstrates output parameters
                    Console.ReadLine();

////--------------------------------------            

            int y = 8;

            int sum4 = ob.Displayz(y,y);//demonstrates overload method applied to same method

            Console.WriteLine(sum4);





////--------------------------------------
            Console.WriteLine(ProfessorInfo.Subject);//identifies object as static class and refers to it by running assorted values through it
            ProfessorInfo.Name = "Professor Plum";
            ProfessorInfo.Rank = 8;
            ProfessorInfo.School = "University of Academia";
            ProfessorInfo.Years = 10;
            Console.WriteLine(ProfessorInfo.Name);
            Console.WriteLine(ProfessorInfo.CalculateScore(3, 10));
            Console.ReadKey();
        }



    }

    }


        
    
