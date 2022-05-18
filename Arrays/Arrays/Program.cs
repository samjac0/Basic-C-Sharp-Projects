using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Array
            string[] strArray1 = new string[] { "Red", "Blue", "Yellow", "Brown", "Green"};
            Console.WriteLine("Please pick a number between 0-4.");
            int index = Convert.ToInt32(Console.ReadLine());
           
            if (index <= 4 && index >= 0) 
                { Console.WriteLine("You chose " + (strArray1[index])); }
            else
                { Console.WriteLine("That didn't work. Please restart and follow the instructions carefully."); return; } //'return' is used to avoid errors or having to create a loop
            //End String Array

            //Integer Array
            int[] intArray2 = new int[] { 200, 300, 400, 523, 600 };
            Console.WriteLine("\n\nAgain please pick a number between 0-4.");
            int index2 = Convert.ToInt32(Console.ReadLine());

            if (index2 <= 4 && index2 >= 0)
            { Console.WriteLine("You chose " + (intArray2[index2])); }
            else
            { Console.WriteLine("That didn't work. Please restart and follow the instructions carefully."); return; } //'return' is used to avoid errors or having to create a loop
            //End Integer Array


            string name = strArray1[index] + intArray2[index2]; //combines the variables from both arrays

            Console.WriteLine("\nYour secret agent code-name is " + name);


            //String List
            Console.WriteLine("\n\nFinally, please pick a number between 0-4 ONE LAST TIME.");
            
            List<string> strList = new List<string>(); // 
                strList.Add("Cherry Blossom");
                strList.Add("Red Panda");
                strList.Add("Eagle Rising");
                strList.Add("Jumping Jerry");
                strList.Add("Ketchup & Mustard");
            
            int mission = Convert.ToInt32(Console.ReadLine());
            if (mission <= 4 && mission >= 0)
            { Console.WriteLine("Your secret-mission assignment is " + (strList[mission])); }
            else
            { Console.WriteLine("You are a failure, " + name + ". Your are being scheduled for cognitive re-assingment" ); return; } //'return' is used to avoid errors or having to create a loop
            //End String List


            Console.ReadLine();




            //Excercises below:
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
            //Console.WriteLine(numArray1[3]); 
            //Console.ReadLine();
        }
    }
}
