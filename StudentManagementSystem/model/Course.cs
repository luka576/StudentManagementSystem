public class Course 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher AssignedTeacher { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();
}