namespace MyUniversity;
internal sealed class Course
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
        return obj is Course c && Name == c.Name && Description == c.Description;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Description);
    }
}
