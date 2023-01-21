namespace MyUniversity;

internal class UniversityEmployee: IUniversityEntity
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
        return obj is UniversityEmployee u && TaxId == u.TaxId;
    }

    public override int GetHashCode()
    {
        return TaxId.GetHashCode();
    }
}
