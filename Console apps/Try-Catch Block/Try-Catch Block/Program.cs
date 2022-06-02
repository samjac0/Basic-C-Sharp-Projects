using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a positive integer in order to recieve your lucky string of numbers.");
            List<int> numList = new List<int>() { 115, 66, 154, 340, 234, 99, 721 };

            try
            {
                byte userNum = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("\n \nYour lucky Numbers are the following: ");

                foreach (int num in numList)
                {
                    int result = num / userNum;
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again and write a number > 0.");
            }
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
            finally
            {
                Console.WriteLine("\nRestart the program to recieve new numbers");
            }


            Console.ReadLine();
        }
    }
}
