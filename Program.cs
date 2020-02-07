/*
 * Author: Leticia W. De Sousa
 * Date: 02/04/2020
 * Description:
 */
using System;

namespace Deliverable_3_1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Application displays an array of 25 numbers:");

            //Use Try
            try
            {
                //Declare and sorte the 25 elements in the array
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Array.Sort(numbers);
                //Interate 
                foreach (int i in numbers)
                {
                    Console.WriteLine("Element value=" + i + " ");

                }
            } /// end of try
            //
            catch
            {
                Console.WriteLine("ERROR IN THE TRY BLOCK..");
                Console.WriteLine("PRESS ANY KEY TO EXIT");

            }



        }
    }
}
