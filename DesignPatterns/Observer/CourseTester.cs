using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class CourseTester
    {
        static void Main(string[] args)
        {
            Course it = new Course("206010", "Information Technology", 75000);
            it.Attach(new Student("Kabelo"));
            it.Attach(new Student("Carol"));
            it.Attach(new Student("Thabo"));

            it.Price = 120000;


        }
    }
}
