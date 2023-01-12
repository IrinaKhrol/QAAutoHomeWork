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


    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        else
        {
            Teacher? t = obj as Teacher;
            return (Course.Equals(t.Course));
        }
    }
}
