namespace MyUniversity;

internal class Building: UniversityProperty, IUniversityEntity
{
    public string Address { get; set; }
    public List<Room> rooms { get; set; }
    public override int Cost { get; set; }


    public override bool Equals(object? obj)
    {
        return obj is Building b && Address == b.Address;
    }

    public override int GetHashCode()
    {
        return Address.GetHashCode();
    }
}


