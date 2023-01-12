namespace MyUniversity;

internal class Course
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Course(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        else
        {
            Course? c = obj as Course;
            return (Name == c.Name) && (Description == c.Description);
        }
    }

}
