namespace MyUniversity;

    internal class SupportStaff: UniversityEmployee
    {
        public string StaffName { get; set; }
        public string Duties { get; set; }

        public SupportStaff(Person person, int taxID, string staffName, string duties) : base(person, taxID)
        {
            StaffName = staffName;
            Duties = duties;
        }
        public override string GetOfficialDuties()
        {
            return StaffName + " " + Duties;
        }
        public override string GetPositionName()
        {
            return "SupportStaff";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
            SupportStaff? s = obj as SupportStaff;
                return (StaffName == p.StaffName) && (Duties == p.Duties);
            }
        }
    }
