using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Course
    {
        public string Code { get; set; }
        public string Desc { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set {
                if (price != value)
                {
                    price = value;
                    Notify();
                } 
             }
        }

        private List<Student> StList { get; set; } = new List<Student>();

        public Course(string theCode, string theDesc, double thePrice)
        {
            this.Code = theCode;
            this.Desc = theDesc;
            this.Price = thePrice;
        }
        public void Attach(Student st)
        {
            StList.Add(st);
        }
        public void Detach(Student st)
        {
            StList.Remove(st);
        }
        public void Notify()
        {

            StList.ForEach(st => st.Update(this));

        }

    }
}
