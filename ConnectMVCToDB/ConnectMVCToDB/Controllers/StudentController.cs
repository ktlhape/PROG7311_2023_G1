using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConnectMVCToDB.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ConnectMVCToDB.Controllers
{
    public class StudentController : Controller
    {
        private IConfiguration _configuration;
        private string con;

        public StudentController(IConfiguration configuration)
        {
            this._configuration = configuration;
            this.con = _configuration.GetConnectionString("dbConnect");
        }
        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> stList = new List<Student>();
            SqlConnection myConnection = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTS",myConnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
            DataTable myTable = new DataTable();
            DataRow myRow;
            string stNum = "", name = "", surname = "";

            myConnection.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];
                    stNum = (string)myRow[0];
                    name = (string)myRow[1];
                    surname = (string)myRow[2];
                    Student st = new Student(stNum,name,surname);
                    stList.Add(st);
                }

            }

            myConnection.Close();
            return View(stList);
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
        public ActionResult Create(IFormCollection collection)
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
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
