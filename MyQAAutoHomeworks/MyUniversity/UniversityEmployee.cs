namespace MyUniversity;

internal class UniversityEmployee
{
    public Person Person { get; set; }
    public int TaxId { get; set; }

    public UniversityEmployee(Person person, int taxId)
    {
        Person = person;
        TaxId = taxId;
    }
    public virtual string GetOfficialDuties()
    {
        return "Be on time at the University";
    }

    public virtual string GetPositionName()
    {
        return "University Employee";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        else
        {
            UniversityEmployee? u = obj as UniversityEmployee;
            return (TaxId == u.TaxId);
        }
    }
}
