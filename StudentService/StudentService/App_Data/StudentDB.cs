using StudentService.Models;
using System.Collections.Generic;
namespace StudentService.Data
{
    public static class StudentDB
    {
        public static List<Student> Students { get; set; } = new List<Student>() {

            new Student(1, "Jessica","Jones",18,'F'),
            new Student(2, "Kabelo","Tlhape",18,'M'),
            new Student(3, "Lerato","Zulu",18,'F'),
            new Student(4, "Carol","Smith",19,'F'),
            new Student(5, "Kevin","Jones",18,'M'),
            new Student(6, "Thabo","Zulu",21,'M'),
            new Student(7, "Caroline","Smith",17,'F'),
        };
    }
}
