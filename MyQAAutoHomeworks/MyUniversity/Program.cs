namespace MyUniversity;

    internal class Program
    {
    static void Main(string[] args)
    {
        var employee1 = new Teacher 
            (new Person("Ivan", "Ivanov"),
            0101,
            new Course("Phyth", "Qvantum Theory"));

        var employee2 = new DegreeTeacher
            (new Person("Irina", "Chernyavskaya"),
            0201,
            new Course("Biology", "Brain"),
            "Masterdegree",
            "Docent");

        var employee3 = new DegreeTeacher
            (new Person("Olga", "Volnaya"),
            0301,
            new Course("Chemistry", "Air"),
            "Proffessor",
            "Docent");

        var employee4 = new SupportStaff
            (new Person("Igor", "Krylov"), 
            0401,
            "Driver",
            "Driver Children");

        var employee5 = new SupportStaff
            (new Person("Peter", "Pen"),
            0501,
            "Cleaner",
            "Clean Window");

        UniversityEmployee[] universityEmployees = new UniversityEmployee[]
        {
            employee1,
            employee2,
            employee3,
            employee4,
            employee5
        };

        Console.WriteLine("---------------University Employees-----------------");


        foreach (UniversityEmployee employee in universityEmployees)
        {
            Console.WriteLine("University employess:" + employee.GetOfficialDuties());
        }

        Console.WriteLine();
        Console.WriteLine("--------------------Teachers-----------------------");


        foreach (UniversityEmployee employee in universityEmployees)
        {
            if (employee is Teacher)
            {
                Console.WriteLine("University employess:" + employee.GetOfficialDuties());
            }
        }
    }
}
