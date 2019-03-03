using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter enter a number from 1 to 3: ");
            var input = Console.ReadLine();
            bool number = int.TryParse(input, out int num);

            if (!number)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter only a number from 1 to 3.");
                    break;
            }
        }
    }
}
