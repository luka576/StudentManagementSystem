public class Grade
{
    public int Id { get; set; }
    public double Score { get; set; }
    public Student TargetStudent { get; set; }
    public Course TargetCourse { get; set; }
}
