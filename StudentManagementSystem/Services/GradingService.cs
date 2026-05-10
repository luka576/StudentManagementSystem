public class GradingService : IGradingService
{
    public void AddGrade(Student student, Course course, double score)
    {
        if (score < 0 || score > 100)
        {
            throw new InvalidGradeException($"Invalid score: {score}. Score must be between 0 and 100.");
        }

        Grade grade = new Grade
        {
            TargetStudent = student,
            TargetCourse = course,
            Score = score
        };
        student.Grades.Add(grade);
    }
    public double CalculateAverage(Student student)
    {
        if (student.Grades.Count == 0)
        {
            return 0;
        }

        double totalScore = 0;
        foreach (var grade in student.Grades)
        {
            totalScore += grade.Score;
        }
        return totalScore / student.Grades.Count;
    }
    
}
