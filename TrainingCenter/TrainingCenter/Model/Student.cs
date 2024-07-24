namespace TrainingCenter.Model;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Course> courses { get; set; } = new List<Course>();
}
