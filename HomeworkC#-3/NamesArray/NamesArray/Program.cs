using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameArray = new string[100];
            int i = 0;
            bool flag = true;
            while (flag)
            {
                Console.Write("Please enter a name: ");
                string input = Console.ReadLine();
                nameArray[i] = input;
                i++;
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(nameArray[j]);
                }

                Console.WriteLine("Do you want to enter another name(Y / N)?");
                string answer = Console.ReadLine();
                if(answer.ToUpper() == "N")
                {
                    flag = false;
                }
            }
            //or ------------------------------------------------------------------
            /*for (int i = 0; i < nameArray.Length; i++)
            {
                Console.Write("Please enter a name: ");
                string input = Console.ReadLine();
                nameArray[i] = input;

                for (int j = 0; j <= i; j++) //ovde morav da go stava j <= i zashto inace ne gi printa site
                {
                    Console.WriteLine(nameArray[j]);
                }

                Console.WriteLine("Do you want to enter another name(Y / N)?");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "N")
                {
                    break;
                }
            }*/
        }
    }
}
