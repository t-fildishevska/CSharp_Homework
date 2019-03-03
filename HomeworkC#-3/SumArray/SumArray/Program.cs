using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declare a new array of integers with 5 elements

            Initialize the array elements with values from input

            Sum all the values and print the result in the console*/

            var arrayFive = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                bool tryParse = int.TryParse(input, out int num);
                if (tryParse)
                {
                    arrayFive[i] = num;
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                    return;
                }
            }

            int sumArray = 0;
            foreach (var element in arrayFive)
            {
                sumArray += element;
            }
            Console.WriteLine($"The sum of all elements is {sumArray}.");

        }
    }
}
