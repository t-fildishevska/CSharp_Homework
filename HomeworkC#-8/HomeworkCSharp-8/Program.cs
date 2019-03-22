using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a PhoneBook Dictionary with 5 names and phone numbers. 
            //Through the console ask the person to enter a name.
            //Try and find that names phone number in your PhoneBook
            //If you can find it, print it in the console
            //If you can’t, print an error message

            Dictionary<string, int> phoneBook = new Dictionary<string, int>
            {
                { "Jordan", 071123456 },
                { "Marija", 078123456 },
                { "Stefan", 075987654 },
                { "Alex", 070321654 },
                { "Igor", 079156247 }
            };

            Console.Write("Enter the name: ");
            string person = Console.ReadLine();

            person = char.ToUpper(person[0]) + person.Substring(1);
            if (phoneBook.ContainsKey(person))
            {
                Console.WriteLine($"{person} - {phoneBook[person]}");
            }
            else
            {
                Console.WriteLine("No such person exists!");
            }
        }
    }
}
