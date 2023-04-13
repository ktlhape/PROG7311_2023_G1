using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }

        private static Student student;
        private Student(){}
        private Student(string id, string name)
        {
            StudentID = id;
            Name = name;
        }
        public static Student GetStudent(string x, string y)
        {
            if (student == null)
            {
                student = new Student(x, y);
            }
            return student;
        }


    }
}
