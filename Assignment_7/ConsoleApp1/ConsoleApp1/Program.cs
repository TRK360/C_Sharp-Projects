using System;
using System.Linq;
using System.Collections.Generic;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please Guess a common European Country:");

            List<string> MyList1 = new List<string> { "Algeria", "France", "Canada", "England", "Egypt", "France", "Ireland", "Spain", "Switzerland", "France", "Germany", "France" };

            //List<string> MyList1 = new List<string>();//Listed string items
            //MyList1.Add("Algeria");
            //MyList1.Add("Argentina");
            //MyList1.Add("Canada");
            //MyList1.Add("England");
            //MyList1.Add("Egypt");
            //MyList1.Add("France");
            //MyList1.Add("Ireland");
            //MyList1.Add("France");
            //MyList1.Add("Spain");
            //MyList1.Add("Switzerland");
            //MyList1.Add("France");


            List<string> qualifyingCountries = new List<string>();


            //var product=MyList1.Where(x=> x.country=="France");
            //foreach(var data in product)
            ///{
            //if (!qualifyingCountries.Exists(x => x.country == data.country))
            //{ qualifyingCountries.Add(data); }



            //}


            //}








            //qualifyingCountries = MyList1
            //        .Select((v, i) => new int { Index = i, Value = v })
            //        .Where(x => x.Value == "France")
            //        .Select(x => x.Index)
            //        .ToList();





            //var i = 0;

            //foreach (var value in MyList1)

            //{

            //    if (value == "France")
            //        qualifyingCountries.Add(i); //foundHelloWorld must be an IList

            //    i++;
            //}



            string item = "France";
            int ListCount1 = MyList1.Count;
            int index = MyList1.IndexOf(item);
            //

            //foreach (string country in MyList1)

            //if (country == item) { qualifyingCountries.Add(item+index);
            //Console.WriteLine(item + "  was added to the new list  " + index);
            // }

            for (int i=0; i<qualifyingCountries.Count;i++) {
             

            Console.WriteLine(qualifyingCountries[i]);
            // }

            //Console.WriteLine(qualifyingCountries);

            while (index < ListCount1)
                
                if (index != -1)
                {
                    Console.WriteLine(String.Format("Element {0} is found at id {1}", item, index));
                    continue;

                    //}
                    //else
                    //{
                    //    Console.WriteLine("Element not found in this list. \n\n ---Closing Program Now---.");
                    //    Environment.Exit(0);
                    //}
                }
        }
    }
}
