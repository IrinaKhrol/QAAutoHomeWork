namespace MyUniversity;

internal class DegreeTeacher : Teacher
{
    public string ScienceDegree { get; set; }
    public string TitleTeaching { get; set; }

    public DegreeTeacher (Person person, int taxId, Course course, string scienceDegree, string titleTeaching) : base(person, taxId, course)
    {
        ScienceDegree = scienceDegree;
        TitleTeaching = titleTeaching;
    }

    public override string GetOfficialDuties()
    {
        return $"{Course.Name} { Course.Description} {ScienceDegree}";
    }
    public override string GetPositionName()
    {
        return "DegreeTeacher";
    }

}
