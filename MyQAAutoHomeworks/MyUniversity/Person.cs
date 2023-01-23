namespace MyUniversity;
internal sealed class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        if (firstName.Length + lastName.Length > 20)
        {
            throw new ArgumentException("Wrong firstName and lastName");
        }
        FirstName = firstName;
        LastName = lastName;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person p && FirstName == p.FirstName && LastName == p.LastName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }
}

