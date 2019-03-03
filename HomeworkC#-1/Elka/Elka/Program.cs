using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elka
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int star = 1;
            int space = 10;

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                space--;
                for(int k = 0; k < star; k++)
                {
                    Console.Write("* ");
                }
                star++;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            //couldn't find brown therefore cyan it is
            Console.WriteLine("         | |");
            Console.WriteLine("         | |");
            Console.ForegroundColor = oldColor;
            Console.ReadKey();
        }
    }
}
