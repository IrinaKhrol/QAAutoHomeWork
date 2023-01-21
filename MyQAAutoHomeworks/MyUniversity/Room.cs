namespace MyUniversity;

internal class Room
{
    public string Purpose { get; set; }
    public int Number { get; set; }
    public Room (string purpose, int number)
    {
        Purpose = purpose;
        Number = number;
    }
}
