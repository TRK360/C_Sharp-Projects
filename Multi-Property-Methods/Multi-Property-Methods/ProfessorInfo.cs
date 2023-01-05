using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Property_Methods
{
    public static class ProfessorInfo//everything below is a static entry to the professor type paired with receiving input parameters by name structure
    {
        // static field  
        public static string Subject = "History";
        // private fields  
        private static string name;
        private static string school;
        private static int rank;
        private static int years;
        // static properties  
        public static int Years { get => years; set => years = value; }
        public static int Rank { get => rank; set => rank = value; }
        public static string School { get => school; set => school = value; }
        public static string Name { get => name; set => name = value; }
        // static method  
        public static int CalculateScore(int rank, int years)
        {
            return rank * years;
        }
    }
}
