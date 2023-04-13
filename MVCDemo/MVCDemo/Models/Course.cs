namespace MVCDemo.Models
{
    public class Course
    {
        public string? Code { get; set; }
        public string? Desc { get; set; }
        public double Cost { get; set; }
        public ICollection<Student>? Students { get; set; }

        public Course(string? code, string? desc, double cost)
        {
            Code = code;
            Desc = desc;
            Cost = cost;
        }
    }
}
