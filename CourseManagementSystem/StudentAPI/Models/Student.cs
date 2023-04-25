namespace StudentAPI.Models
{
    public class Student
    {
        public int StudentNum { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Student()
        {
            
        }
        public Student(int studentNum, string? firstname, string? lastname, int age, char gender)
        {
            StudentNum = studentNum;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Gender = gender;
        }
    }
}
