namespace MyUniversityActive;
    internal class Building: UniversityProperty
    {
        public string Address { get; set; }
        public List<Room> rooms { get; set; }
        public override int Cost { get; set; }
    }
