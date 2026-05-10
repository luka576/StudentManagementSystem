using System;
using System.Data.Common;
public class Program
{
    public static void Main()
    {
        Teacher teacher1 = new Teacher { Name = "Alice", Id = 1 };
        Teacher teacher2 = new Teacher { Name = "Bob", Id = 2 };

        Student student1 = new Student { Name = "Charlie", Id = 3 };
        Student student2 = new Student { Name = "Diana", Id = 4 };

        Course course1 = new Course { Name = "Calculus 2", Id = 5 };
        Course course2 = new Course { Name = "Object-Oriented Programming", Id = 6 };

        CourseService courseService = new CourseService();
        StudentService studentService = new StudentService();

        courseService.AssignTeacher(teacher1, course1);
        courseService.AssignTeacher(teacher2, course2);

        courseService.EnrollStudent(student1, course1);
        courseService.EnrollStudent(student2, course2);

        GradingService gradingService = new GradingService();
        gradingService.AddGrade(student1, course1, 95.5);
        gradingService.AddGrade(student1, course2, 89.0);
        gradingService.AddGrade(student2, course2, 83.0);

        Console.WriteLine("All Students:");
        studentService.PrintAllStudents(new List<Student> { student1, student2 });
        Console.WriteLine($"Average grade for {student1.Name}: {gradingService.CalculateAverage(student1)}");
        Console.WriteLine($"Average grade for {student2.Name}: {gradingService.CalculateAverage(student2)}");
    }
}
