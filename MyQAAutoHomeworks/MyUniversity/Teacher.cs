namespace MyUniversity;

    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }
        public Teacher(Person person, int taxID, Course course): base(person, taxID)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return Course.Name + " " + Course.Description;
        }
        public override string GetPositionName()
        {
            return "Teacher";
        }

}
