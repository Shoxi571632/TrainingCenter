namespace TrainingCenter.Model;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Stack { get; set; }
    public List<Course> courses { get; set; } = new List<Course>();
}