public class StudentService
{
   public void PrintAllStudents(List<Student> students)
    {
        foreach (var student in students)
        {
            student.PrintDetails();
            Console.WriteLine("------------");
        }
    }
}
