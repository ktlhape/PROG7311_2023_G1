using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmployeeBuilder
    {
        public string StaffNo { get; set; }
        public string IDNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public bool SACitizen { get; set; }

        public EmployeeBuilder WithStaffNo(string staffNo)
        {
            this.StaffNo = staffNo;
            return this;
        }
        public EmployeeBuilder WithName(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            return this;
        }
        public EmployeeBuilder WithEmail(string email)
        {
            this.Email = email;
            return this;
        }
        public EmployeeBuilder WithCredentials(string username, string pass)
        {
            this.Username = username;
            this.Password = pass;
            return this;
        }
        public EmployeeBuilder WithNationality(string nationality)
        {
            this.Nationality = nationality;
            return this;
        }
        public EmployeeBuilder WithSalary(double sal)
        {
            this.Salary = sal;
            return this;
        }
        public EmployeeBuilder WithCitizenship(bool saCitizen)
        {
            this.SACitizen = saCitizen;
            return this;
        }
        public EmployeeBuilder WithID(string idNum)
        {
            this.IDNumber = idNum;
            return this;
        }
        public EmployeeBuilder Build()
        {
            if (ValidateBuild())
            {
                throw new Exception("Invalid ID Number");
            }
            return this;
        }
       private bool ValidateBuild()
        {
            return IDNumber.Length != 13;
        }
        public override string ToString()
        {
            return $"Staff No: {StaffNo}\n" +
                $"ID Number: {IDNumber}\n" +
                $"Name: {Name} {Surname}\n" +
                $"Email: {Email}\n" +
                $"Nationality: {Nationality}\n" +
                $"Salary: {Salary}\n" +
                $"Is SA Citizen? {SACitizen}";


        }
    }
}
