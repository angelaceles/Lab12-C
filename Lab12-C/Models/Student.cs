namespace Lab12_C.Models
{
    public class Student
    {
        public Student() 
        {
            Enrollments = new List<Enrollment>();
        }
        public int StudentId { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
