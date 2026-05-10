public class CourseService
{
    public void AssignTeacher(Teacher teacher, Course course)
    {
        course.AssignedTeacher = teacher;
    }
    public void EnrollStudent(Student student, Course course)
    {
        course.EnrolledStudents.Add(student);
    }
}
