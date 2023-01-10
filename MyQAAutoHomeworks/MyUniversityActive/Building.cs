namespace MyUniversityActive;
    internal class Building: UniversityProperty
    {
        public string Address { get; set; }
        public Room[] rooms { get; set; }
        public override int Cost { get; set; }
    }
