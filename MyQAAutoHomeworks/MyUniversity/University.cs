namespace MyUniversity;

internal class University
{
    
    public List<UniversityEmployee> UniversityEmployees { get; set; }
    public string Rector { get; set; }
    public List<Building> Buildings { get; set; }

    public bool AddEmployee(UniversityEmployee e)
    {
        foreach(UniversityEmployee employee in UniversityEmployees)
        {
            if(employee.Equals(e))
                return false;
        }
        UniversityEmployees.Add(e);
        return true;
    }

    public bool AddBuilding(Building b)
    {
        foreach (Building building in Buildings)
        {
            if (building.Equals(b))
                return false;
        }
        Buildings.Add(b);
        return true;
    }
}
