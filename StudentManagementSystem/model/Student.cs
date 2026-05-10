public class Student : Person, IPrintable
{
    public List<Grade> Grades { get; set; } = new List<Grade>();
    public void PrintDetails()
    {
        Console.WriteLine($"Student ID: {Id}, Name: {Name}");
        Console.WriteLine("Grades:");
        foreach (var grade in Grades)
        {
            Console.WriteLine($"Course: {grade.TargetCourse.Name}, Score: {grade.Score}");
        }
    }
}
