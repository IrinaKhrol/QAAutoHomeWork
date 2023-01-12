namespace MyUniversity;

internal class Building: UniversityProperty
{
    public string Address { get; set; }
    public List<Room> rooms { get; set; }
    public override int Cost { get; set; }


    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        else
        {
            Building? b = obj as Building;
            return (Address == b.Address);
        }
    }
}


