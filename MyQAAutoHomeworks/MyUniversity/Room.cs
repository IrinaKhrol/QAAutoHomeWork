namespace MyUniversity;

public class Room
{
    private const int Max_Room_Number = 10000;
    public string Purpose { get; set; }
    private int _number { get; set; }

    public int Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (value > 0 && value < Max_Room_Number) 
            { 
                _number= value;
            }
        }
    }
    public Room (string purpose, int number)
    {
        Purpose = purpose;
        Number = number;
    }
}
