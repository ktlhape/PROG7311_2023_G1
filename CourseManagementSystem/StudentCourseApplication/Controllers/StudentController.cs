using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Data;
using Newtonsoft.Json;
using System.Text;

namespace StudentCourseApplication.Controllers
{
    public class StudentController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:5018/api/Student/");
        private readonly HttpClient _client;

        public StudentController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> stList = new List<Student>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "AllStudents/All").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                stList = JsonConvert.DeserializeObject<List<Student>>(data);
            }
            return View(stList);
        }
        [HttpGet]
        public ActionResult GetStudent(int id)
        {
            Student st = new Student();
            HttpResponseMessage response = _client.GetAsync($"{_client.BaseAddress}GetStudentByID/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                st = JsonConvert.DeserializeObject<Student>(data);
            }
            return View(st);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection col)
        {
            try
            {
                Student st = new Student(Convert.ToInt32(col["txtStNum"]),
                        col["txtName"], col["txtLastname"], Convert.ToInt32(col["txtAge"]),
                        Convert.ToChar(col["txtGender"]));

                string data = JsonConvert.SerializeObject(st);
                StringContent content = new StringContent(data, Encoding.UTF8,
                    "application/json");
                HttpResponseMessage response = _client.PostAsJsonAsync($"{_client.BaseAddress}Create?stNum={st.StudentNum}&name={st.Firstname}&surname={st.Lastname}&age={st.Age}&gender={st.Gender}", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
              
                return View();
            }
            return View();
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection col)
        {
            try
            {
                Student st = new Student();
                HttpResponseMessage response = _client.GetAsync($"{_client.BaseAddress}DeleteStudent/{id}").Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

           
        }
    }
}
