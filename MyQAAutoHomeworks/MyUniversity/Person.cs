namespace MyUniversity;

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person p && FirstName == p.FirstName && LastName == p.LastName;
    }
}

