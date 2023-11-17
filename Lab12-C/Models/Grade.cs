namespace Lab12_C.Models
{
    public class Grade
    {
        public Grade() 
        {
            Students =new List<Student>();
        }
        public int GradeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Student> Students { get; set; }
    }
}
