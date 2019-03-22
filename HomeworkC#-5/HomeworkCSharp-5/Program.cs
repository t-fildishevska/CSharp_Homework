using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCSharp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array with 5 new Students(objects)
            //The user should enter a name and the user information should be displayed in the console if a user by that name exists
            //If there is no such user it should show an error message

            var student1 = new Student("Teodora", "WD", "G4");
            var student2 = new Student("Andrej", "WD", "G4");
            var student3 = new Student("Kristina", "WD", "G4");
            var student4 = new Student("Marko", "WD", "G4");
            var student5 = new Student("Alek", "WD", "G4");

            Student[] Students = { student1, student2, student3, student4, student5 };

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine(CheckName(name, Students));
        }

        static Student CheckName(string name, Student[] Students)
        {
            foreach (var student in Students)
            {
                if (name.ToLower() == student.Name.ToLower())
                {
                    return student;
                }
            }
            throw new Exception("No such student!");
        }
    }
}
