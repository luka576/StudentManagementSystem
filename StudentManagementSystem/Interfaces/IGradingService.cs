public interface IGradingService
{
    void AddGrade(Student student, Course course, double score);
    double CalculateAverage(Student student);
}
