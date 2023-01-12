namespace MyUniversity;

internal class University
{
    
    public List<UniversityEmployee> UniversityEmployees { get; set; }
    public string Rector { get; set; }
    public List<Building> Buildings { get; set; }

    /*
        Для всех сущностей, включающих списки List, обеспечить уникальность объектов в списке. 
    Например, в университете должен быть только один сотрудник с конкретным ТахId,
    попытка добавления сотрудника с тем же TaxId не должна быть успшной (сотрудник не добавляется).
    Для этого в классе University сделать publuc метод AddEmployee, 
    который проходит по списку сотрудников и сранивает их с новым кандидатом при помощи Equals.
    Если сотрудник с таким TaxId не найден, добавляет его в список. 
        */
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
