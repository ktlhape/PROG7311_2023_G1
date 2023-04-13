namespace MVCDemo.Models
{
    public class Student
    {
        public string? StNumber { get; set; }
        public string? Name { get; set; }
        public double TestMark { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public Student(){}
        public Student(string? stNumber, string? name, double testMark)
        {
            StNumber = stNumber;
            Name = name;
            TestMark = testMark;
        }

        public Student(string? username, string? password)
        {
            Username = username;
            Password = password;
        }
    }
}
