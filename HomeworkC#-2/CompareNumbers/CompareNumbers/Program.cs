using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string number1 = Console.ReadLine();
            bool firstNum = int.TryParse(number1, out int num1);
            if (!firstNum)
            {
                Console.WriteLine("You've entered an incorrect value.");
                return;
            }

            Console.Write("Enter the second number: ");
            string number2 = Console.ReadLine();
            bool secondNum = int.TryParse(number2, out int num2);
            if (!secondNum)
            {
                Console.WriteLine("You've entered an incorrect value.");
                return;
            }

            int maxNum = (num1 > num2) ? num1 : num2;
            string oddEven = (maxNum % 2 == 0) ? "even" : "odd";
            if(num1 == num2)
            {
                Console.WriteLine($"Both numbers are equal and they are {oddEven} numbers.");
            }
            else
            {
                Console.WriteLine($"Between {num1} and {num2} the bigger one is {maxNum}, which is an {oddEven} number.");
            }

            
        }
    }
}
