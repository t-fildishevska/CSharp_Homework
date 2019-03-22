using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkCSharp_5
{
    class Student
    {
        //Create a class Student that has properties: Name, Academy and Group
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public override string ToString()
        {
            return $"{Name}, enrolled in {Academy} academy in group {Group}.";
        }
    }
}
