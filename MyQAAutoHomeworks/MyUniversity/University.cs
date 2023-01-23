using System.Linq;
using System.Reflection.Metadata;

namespace MyUniversity;

internal class University
{
    public List<UniversityEmployee> UniversityEmployees { get; set; }
    public string Rector { get; set; }
    public List<Building> Buildings { get; set; }


    public bool Add <T> (T item, List<T> listitems) where T:UniversityEntity
    {
        if (listitems.Contains(item))
        {
            return false;
        }

        listitems.Add(item);

        return true;
    }
}