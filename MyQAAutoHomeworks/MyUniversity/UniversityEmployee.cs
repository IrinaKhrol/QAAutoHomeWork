namespace MyUniversity;

internal class UniversityEmployee: UniversityEntity , IComparable<UniversityEmployee>
{
    public Person Person { get; set; }
    public int TaxId { get; set; }

    public UniversityEmployee(Person person, int taxId)
    {
        Person = person;
        if(taxId < 0) 
        {
                throw new ArgumentException("Wrong TaxId");
        }
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


    public int CompareTo(UniversityEmployee emp)
    {
        if (emp == null)
        {
            return 1;
        }

        return Comparer<int>.Default.Compare((this.Person.FirstName.Length + this.Person.LastName.Length), (emp.Person.FirstName.Length + emp.Person.LastName.Length));
    }
}
