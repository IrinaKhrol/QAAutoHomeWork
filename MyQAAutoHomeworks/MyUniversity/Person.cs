namespace MyUniversity;
public sealed class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        if (firstName == null || lastName == null)
        {
            throw new ArgumentNullException("Attention empty field");
        }

        FirstName = firstName;
        LastName = lastName;

        if (FullNameLen() > 20)
        {
            throw new ArgumentException("Too long firstName and lastName");
        }
    }

    public int FullNameLen()
    {
        return FirstName.Length + LastName.Length;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person p && FirstName == p.FirstName && LastName == p.LastName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}

