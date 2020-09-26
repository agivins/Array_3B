/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of an Array statements after getting input from users. 
*/
using System;
using System.Data.SqlTypes;
using System.Security;

namespace Array
{
    class Program
    {


        static void Main(string[] args)
        {
            // No User input
            Console.WriteLine(" ");
            Console.WriteLine("Executing a For Value! ");


            // this variable will gather data 

            // If the value of user input is between 1 and 20, manually populate an array and iterate throught its vales 

            {
                int pop_array = 0;

                Console.WriteLine("");
                Console.WriteLine(" First, let's manually populate an array with integers.");
                Console.WriteLine(" Then, let's iterate through the elements in array with a foreach loop");
                // Here is the manually populated arry 
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("Element Value:");
                Console.WriteLine("The value is " + numbers[pop_array] + "in element a " + pop_array + "of the array ");
                Console.WriteLine(" Here are the values in each element of the array:");

                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                // Iterate through the array with a Foreach Loop
                foreach (int i in numbers)

                    Console.Write("Element Value = " + i + (" "));




                {


                }
                Console.WriteLine("");
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("Press any key to exit the program try again...");
                Console.ReadKey(true);

            }


        }
    }

}





















