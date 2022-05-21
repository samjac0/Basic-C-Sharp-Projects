using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////Part 1; concatenation.//////
            Console.WriteLine("Time to train me! Teach me a word...");
            string[] strArray = new string[] { "My life is ", "My love is ", "There is nothing else but ", "My master is " };
            string userWord = Console.ReadLine();
            for (int i = 0; i < strArray.Length; i++) //for each item in the array...
            {
                strArray[i] = strArray[i] + userWord; //merge the array with a user's input
            }

            foreach (string stringPlusWord in strArray) { Console.WriteLine(stringPlusWord); } //prints each item in the new, 'merged', array.
            Console.ReadLine();


            //////Part 2; infinite loops.//////
            bool boolInfinite = true;
            while (boolInfinite)
            do
            {
                Console.WriteLine("This is an infininate loop! Hit 'esc' to stop this madness!!");
                    boolInfinite = Console.ReadKey().Key != ConsoleKey.Escape;

            }
            while (boolInfinite);
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();



            //////Part 3; loop comparisons.//////
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("I'm a loop that counts to 5 using comparisons: " + i.ToString() + " < 6");
            }
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();





            /// different operand example
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("I'm a loop that counts to 6 using comparisons: " + i.ToString() + " <= 6");
            }
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();



            ////// Part 4; loops and lists //////
            List<string> strList = new List<string>() { "Lisa", "Tommy", "Larry", "Jeff", "Laura", "Julie" };
            Console.WriteLine("This function showcases finding the index of a list entry");
            Console.WriteLine("Please choose a name from the list: Lisa, Tommy, Larry, Jeff, Laura, Julie");
            bool isGuessed = false;
            string userinput = Console.ReadLine();

            do
            {
                for (int i = 0; i < strList.Count; i++)
                    if (strList.Contains(userinput))
                    {


                        if (userinput == strList[i])
                        {
                            Console.WriteLine(strList[i] + " is at index " + i);
                            isGuessed = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("The name you chose is not on the list");
                        Console.WriteLine("Please choose a name from the list: Lisa, Tommy, Larry, Jeff, Laura, Julie");
                        userinput = Console.ReadLine();
                    }
            }
            while (!isGuessed);
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();



            ////// Part 5; identical submissions in a list. //////
            List<string> strList1 = new List<string>() { "Lisa", "Lisa", "Tommy", "Larry", "Jeff", "Laura", "Julie" };
            Console.WriteLine("Now, let's showcase a function that can find the index of multiple duplicates");
            Console.WriteLine("Please choose a name from the list: Lisa, Tommy, Larry, Jeff, Laura, Julie\n*hint* Pick Lisa");
            string userInput1 = Console.ReadLine();

            for (int j = 0; j < strList1.Count; j++)
            {
                if (strList1.Contains(userInput1))
                {


                    if (userInput1 == strList1[j])
                    {
                        Console.WriteLine(strList1[j] + " is at index " + j);
                    }

                }
                else
                {
                    Console.WriteLine("The name you chose is not on the list");
                    break;
                }
            }
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();


            ////// Part 6; identical submissions in a list using a 'foreach' loop. //////
            Console.WriteLine("This functions takes the above list of names and tells a user if there are any duplicates");
            List<string> strList2 = new List<string>() { "Lisa", "Lisa", "Tommy", "Larry", "Jeff", "Laura", "Julie" };
            List<string> dupList2 = new List<string>();

            foreach (string name in strList2)
            {
                if (dupList2.Contains(name))
                {
                    Console.WriteLine(name + " has appeared before");
                }
                else
                {
                    Console.WriteLine(name + " has not appeared before");
                }

                dupList2.Add(name);
            }
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();




            //Simpler Exercises below:
            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99};
            //List<int> passingScores = new List<int>(); 
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);  
            //testScores.Add(81);  
            //testScores.Add(72);  
            //testScores.Add(70);
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}


            //string[] names = { "Jesse", "Erik", "Julie", "Adam" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();


            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //for (int i = 0; i < testScores.Length; i++)
            //{ 
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
