using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCSharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Da presmetuva kolku godini imas, da ima vnes od povekje ljuge. 
            //Da gi podredis po azbucen red tie sto si gi vnel...neso u toj stil
            //presmeta koj ima najdolgo ime i prezime
            var peopleArray = new string[100];
            int i = 0;
            string max = "";


            bool flag = true;
            while (flag)
            {
                Console.Write("Enter your first name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your last name: ");
                string surame = Console.ReadLine();
                Console.WriteLine("Enter your birth date");
                Console.Write("Year: ");
                string yearStr = Console.ReadLine();
                Console.Write("Month: ");
                string monthStr = Console.ReadLine();
                Console.Write("Day: ");
                string dayStr = Console.ReadLine();

                int year = int.Parse(yearStr);
                int month = int.Parse(monthStr);
                int day = int.Parse(dayStr);
                var bDay = new DateTime(year, month, day);

                peopleArray[i] = $"{surame}, {name}, aged {AgeCalculator(bDay)}";
                i++;

                string temp = $"{name} {surame}";
                if(max.Length < temp.Length)
                {
                    max = temp;
                }

                Console.WriteLine("Do you want to add another person? (Y / N)");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "N")
                {
                    flag = false;
                }
            }

            Array.Sort(peopleArray, (person1, person2) => String.Compare(person1, person2));

            foreach (var person in peopleArray)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"The person with the longest name is {max}.");

            Console.ReadKey();
        }

        static int AgeCalculator(DateTime birthday)
        {
            int age = 0;
            var now = DateTime.Today;
            age = (now.Year - birthday.Year);
            if (now.Month < birthday.Month)
            {
                age--;
            }
            else if ((now.Month == birthday.Month) && (now.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }
    }
}
