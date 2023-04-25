using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Data;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All")]
        public List<Student> AllStudents()
        {
            return StudentDB.Students;
        }

        /*create a method that will return the student
         * of a specific id*/
        [HttpGet]
        [Route("{id}", Name = "GetStudent")]
        public Student GetStudentByID(int id)
        {
            return StudentDB.Students.Where(s => s.StudentNum == id).FirstOrDefault();
        }
        [HttpGet]
        [Route("{stname:alpha}", Name = "StudentName")]
        public Student GetStudentName(string stname)
        {
            return StudentDB.Students.Where(s => s.Firstname.Equals(stname)).FirstOrDefault();
        }
        [HttpGet]
        [Route("{surname:alpha}", Name = "StudentSurname")]
        public Student GetStudentSurname(string surname)
        {
            return StudentDB.Students.Where(s => s.Firstname.Equals(surname)).FirstOrDefault();
        }
        [HttpDelete]
        [Route("{id}", Name = "DeleteStudent")]
        public bool DeleteStudent(int id)
        {
            var st = StudentDB.Students.Where(s => s.StudentNum == id).FirstOrDefault();
            return StudentDB.Students.Remove(st);
        }
        [HttpPost]
        [Route("Create")]
        public bool CreateStudent(int stNum, string name, string surname, int age, char gender)
        {
            Student st = new Student(stNum, name, surname, age, gender);

            if (st != null)
            {
                StudentDB.Students.Add(st);
                return true;
            }
            return false;
        }
        [HttpPut]
        [Route("{id}")]
        public bool UpdateStudent(int id, string name, string surname,int age)
        {
            var st = StudentDB.Students.Where(s => s.StudentNum == id).FirstOrDefault();
            if (st != null)
            {
                st.Firstname = name;
                st.Lastname = surname;
                st.Age = age;
                return true;
            }
            return false;
        }
    }
}
