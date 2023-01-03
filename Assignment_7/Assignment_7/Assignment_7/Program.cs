using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
//------------------------------------------------------------------------------------------------
            Console.WriteLine("Beginning First Part of Assignment: String array looping through all list items and adding a user selected text to each:");
            Console.WriteLine("\n\nPlease enter a short word of an item that can be counted");
            string Appendage_1 = "  " + Console.ReadLine();//user inputs text to concantenate

            string[] array_one = new string[] { "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten " };//Manual Array

            int listLgth1 = array_one.Length;//int value used to limit iterations



            for (int i = 0; i < listLgth1; i++)
            {

                array_one[i] = array_one[i] + " " + Appendage_1;
                Console.WriteLine(array_one[i]);//iterates through list and appends user input
            }


//------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nBeginning Second Part of Assignment: Commenting Out an infinite loop and correcting with a properly functioning loop:\n\n");


            int[] array_two = new int[] { 1, 3, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 51 };///starting list

            //for (int n = 0; n < n+1; n++);//This code yields and endless looping of integers (being that N can never be less than N+1)
            //{
            //Console.WriteLine(array_two[n]);
            //}
            int listLgth2 = array_two.Length;
            for (int n = 0; n < listLgth2; n++)//This code executes and reads all items from the array and terminates once the integer to be read exceeds the length of the array
            //
            {

                Console.WriteLine(array_two[n]);
            }

//------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nBeginning Third Part of Assignment: Limiting a loop with a < condition:");
            {
                Console.WriteLine("\n\nPlease enter a number of which you wish to see prime numbers lower than your selected value: (Between 1 and 57 please)");


                List<int> listOptions = new List<int>() { 1, 3, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 51, 53, 57 };// starting list
                int userValue = Convert.ToInt32(Console.ReadLine());//must convert from input string to int for later use

                Console.WriteLine("\n\n");

                foreach (int element in listOptions)//iterates through entire list

                {
                    { if (element < userValue)//limits iterations to what user put in


                            Console.Write($"{element}\n");
                    } }

                ///---------
                List<int> listTotal = new List<int>() { 1, 3, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 51, 53, 57 };//starting list
                Console.WriteLine("\n\nHere is the entire list limited by the analyzing the last element in the list and using it as a limitor in <= format:\n");
                int highInt = listTotal.Count;// total quantity of elements in list
                int highIntg = highInt - 1;//factors in 0 for first element in above count
                int lastNum = listTotal[highIntg];//last number in list for later matching to terminate below loop

                foreach (int truth in listTotal)

                {
                    {
                        if (truth <= lastNum)//limitation set at last number of whole list


                            Console.Write($"{truth}\n");
                    }
                }



            }


//------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nBeginning Fourth Part of Assignment: Retrieving index of searched value in list of unique values:");




            Console.WriteLine("\n\nGuess which color is in my top 5 favorite list:\n");
            {
                //create   a   color  list

                List<string> favColors = new List<string>() { "red", "orange", "yellow", "green", "blue", "black", "white" };//orig list
                string favcolor = Console.ReadLine();//value to search for

                

                int note = favColors.IndexOf(favcolor);//if index ocurrs as not found, this value returns -1 for later check below

                foreach (string choice in favColors)

                    if (note != -1)// if color exists in list
                    {
                        Console.WriteLine(String.Format("\nElement --{0}-- is found at index -{1}-", favcolor, note));
                        break;

                    }
                    else
                    {
                        Console.WriteLine("\n\nThat color is not one of my top 5 favories\n\n---CONTINUING PROGRAM---");
                        break;
                    }// if color does not exist in list
            }



//------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nBeginning Fifth Part of Assignment: Retrieving index of searched value in list with multiples of each available:");

            List<string> MyList1 = new List<string>() { "red", "blue", "red", "white", "blue", "red", "white" };//creates a list with various instances of repeating strings
            Console.WriteLine("\n\nPlease type in a color of the American flag.\n");
            int index = 0;//initializes index as 0 (starting point of the list)
            string userinput = Console.ReadLine();//user inputs one of 3 color options (checked with boolean inspec# below)

            bool inspect1 = MyList1.Contains(userinput);


            Console.WriteLine("\n");

            if (inspect1 == true)//Tests condition of input to determine to throw error code or not
            {
                foreach (string color in MyList1)//loops through entire list

                {
                    if (color.Contains(userinput))
                    {
                        Console.WriteLine($"value of index: {index}:{color}");//returns any instance that matches approved user entry

                    }
                    ///while (value == userinput);// inent is to limit returned results to just red items or blue items or white items and their respective index values, but not all a the same time, just one color group per request
                    index++;//moves forward

                }
            }
            else
            {
                Console.WriteLine("Sincerest apologies, that color is not an option.\n\n---SKIPPING TO NEXT PART OF PROGRAM---");
                
            }
//------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nBeginning Sixth Part of Assignment: Analyzing duplicate instances upon creating a new list to return:\n\n");
            List<string> UtensilsList = new List<string>() { "butter knife", "salad fork", "dinner fork", "soup spoon", "salad fork", "dinner fork", "butter knife", "dinner fork", "soup spoon", "steak knife" };//starting list
            List<string> ResultantList = new List<string>();//blank new list
            Console.WriteLine("Upon searching in ResultantList\n");


            foreach (string utensil in UtensilsList)//loops entire list
   

            {
                
                        if (ResultantList.Contains(utensil))//checks new list and reacts according to below

                            {
                        Console.WriteLine(utensil + " is a duplicate");
                            ResultantList.Add(utensil);//no matter what, something is getting added to the new list
                            }

               

                        else {
                            Console.WriteLine(utensil + " is unique");
                            ResultantList.Add(utensil);
                    
                            }//no matter what, something is getting added to the new list

                      }
            

            //ResultantList.ForEach(Console.WriteLine);

            Console.WriteLine("\n\n\n---THANK YOU   THE PROGRAM IS ENDING NOW---");
            Console.ReadLine();

        }
  

        }
    }

