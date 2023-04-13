using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Student : IStudent
    {
        public string Name { get; set; }

        public Student(string theName)
        {
            this.Name = theName;
        }
       
        public void Update(Course course)
        {
            Console.WriteLine($"Notified {Name}. Course price for {course.Desc} has changed to {course.Price}");
        }
    }
}
