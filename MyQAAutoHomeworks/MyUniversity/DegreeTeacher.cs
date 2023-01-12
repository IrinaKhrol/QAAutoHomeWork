namespace MyUniversity;

    internal class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string TitleTeaching { get; set; }

        public DegreeTeacher (Person person, int taxID, Course course, string scienceDegree, string titleTeaching) : base(person, taxID, course)
        {
            ScienceDegree = scienceDegree;
            TitleTeaching = titleTeaching;
        }
        public override string GetOfficialDuties()
        {
            return Course.Name + " " + Course.Description + " " + ScienceDegree;
        }
        public override string GetPositionName()
        {
            return "DegreeTeacher";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
            return false;
            }
            else
            {
            DegreeTeacher? d = obj as DegreeTeacher;
            return (ScienceDegree == d.ScienceDegree) && (TitleTeaching == d.TitleTeaching);
            }
        }
    }
