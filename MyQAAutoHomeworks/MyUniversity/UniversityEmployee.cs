namespace MyUniversity;
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public int TaxID { get; set; }

        public UniversityEmployee(Person person, int taxID)
        {
            Person = person;
            TaxID = taxID;
        }
        public virtual string GetOfficialDuties()
        {
            return "Be on time at the University";
        }
        public virtual string GetPositionName()
        {
            return "University Employee";
        }
}
