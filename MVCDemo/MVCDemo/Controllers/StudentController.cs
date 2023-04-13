using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        List<Student> stList = new List<Student>();
        public StudentController()
        {
            Populate();
        }
        public IActionResult Index()
        {
            return View(stList);
        }

        public IActionResult Students()
        {
            return View("Index",stList);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidateLogin()
        {
            Student st = new Student("KabeloT", "Pass.123");
            string username = Request.Form["txtUsername"].ToString();
            string pass = Request.Form["txtPass"].ToString();

            if (username.Equals(st.Username) && pass.Equals(st.Password))
            {
                return View("Index",stList);
            }
            else
            {
                return View("Login");
            }
        }
        public void Populate()
        {
            stList.Add(new Student("ST123", "Smith", 74));
            stList.Add(new Student("ST246", "Kabelo", 75));
            stList.Add(new Student("ST345", "Thabo", 70));
            stList.Add(new Student("ST321", "Kelvin", 65));
            stList.Add(new Student("ST789", "Caroline", 66));
        }
    }
}
