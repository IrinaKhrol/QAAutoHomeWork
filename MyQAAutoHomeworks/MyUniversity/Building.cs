namespace MyUniversity;
public class Building: UniversityProperty
{
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }


    public override bool Equals(object? obj)
    {
        return obj is Building b && Address == b.Address;
    }

    public override int GetHashCode()
    {
        return Address.GetHashCode();
    }
}


