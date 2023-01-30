using System;

namespace MyUniversity;
public class UniversityEmployee: UniversityEntity, IComparable<UniversityEmployee>
{
    private Person _person;
    public Person Person
    {
        get
        {
            return _person;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Wrong Person");
            }
            _person = value;
        }
    }

    private int _taxId;
    public int TaxId
    {
        get
        {
            return _taxId;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Wrong TaxId");
            }
            _taxId = value;
        }
    }

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


    public int CompareTo(UniversityEmployee emp)
    {
        if (emp == null)
        {
            return 1;
        }

        return - Person.FullNameLen() + emp.Person.FullNameLen();
    }
}
