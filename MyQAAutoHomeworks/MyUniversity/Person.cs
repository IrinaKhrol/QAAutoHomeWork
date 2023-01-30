namespace MyUniversity;
public sealed class Person
{
    private string _firstName;
    public string FirstName 
    {
        get
        {
            return _firstName;
        }

        set
        {
            validateFullName(value, LastName is null ? "" : LastName);
            _firstName = value;
        }
    }

    private string _lastName;
    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            validateFullName(FirstName is null ? "" : FirstName, value);
            _lastName = value;
        }
    }

    public Person(string firstName, string lastName)
    {
        if (firstName == null || lastName == null)
        {
            throw new ArgumentNullException("Attention empty field");
        }

        FirstName = firstName;
        LastName = lastName;
    }

    private void validateFullName(string firstName, string lastName)
    {
        if ((firstName.Length + lastName.Length) > 20)
        {
            throw new ArgumentException("Too long first name and last name");
        }
    }

    public int FullNameLen()
    {
        return (FirstName.Length + LastName.Length);
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

