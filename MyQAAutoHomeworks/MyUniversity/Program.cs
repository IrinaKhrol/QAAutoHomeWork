using static MyUniversity.DegreeTeacher;
using static MyUniversity.University;

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

        var employee6 = new SupportStaff
            (new Person("Peter", "Pen"),
            0501,
            "Cleaner",
            "Clean Window");

        var employee7 = new SupportStaff
            (new Person("Peter", "Pen"),
            0701,
            "Cleaner",
            "Clean Window");

        var employee8 = new SupportStaff
            (new Person("Oleg", "Ifakov"),
            0801,
            "Driver",
            "Driver Children");

        List<UniversityEmployee> universityEmployees = new List<UniversityEmployee>
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


        var university1 = new University();
        university1.Rector = "Ivan";

        var building1 = new Building();
        building1.Address = "1420, Minsk, office2";
        building1.Cost = 10000000;

        var room1 = new Room("Lection");
        var room2 = new Room("Laboratory");
        List<Room> rooms1 = new List<Room> { room1, room2 };
        building1.rooms = rooms1;

        var building2 = new Building();
        building2.Address = "1420, Minsk, office3";
        building2.Cost = 25000000;

        var room3 = new Room("Lection1");
        var room4 = new Room("Laboratory1");
        List<Room> rooms2 = new List<Room> { room3, room4 };
        building2.rooms = rooms2;

        var building3 = new Building();
        building2.Address = "1555, Minsk, office3";
        building2.Cost = 25000000;

        var room5 = new Room("Lection1");
        var room6 = new Room("Laboratory1");
        List<Room> rooms3 = new List<Room> { room3, room4 };
        building3.rooms = rooms3;

        List<Building> buildings = new List<Building> { building1, building2 };
        university1.Buildings = buildings;


        if (university1.Add<Building>(building2, university1.Buildings))
        {
            Console.WriteLine("New Building has been added");
        }
        else
        {
            Console.WriteLine("New Building has not been added");
        }

        if (university1.Add<Building>(building3, university1.Buildings))
        {
            Console.WriteLine("New Building has been added");
        }
        else
        {
            Console.WriteLine("New Building has not been added");
        }

        // add 

        university1.UniversityEmployees = universityEmployees;

        if (university1.Add<UniversityEmployee>(employee5, university1.UniversityEmployees))
        {
            Console.WriteLine("New Employee has been added");
        }
        else
        {
            Console.WriteLine("New Employee has not been added");
        }


        if (university1.Add<UniversityEmployee>(employee8, university1.UniversityEmployees))
        {
            Console.WriteLine("New Employee has been added");
        }
        else
        {
            Console.WriteLine("New Employee has not been added");
        }





        //var result = university1.Add<UniversityEmployee>(employee6, university1.UniversityEmployees);

        //Console.WriteLine(result);
        Console.WriteLine(university1.Rector);

    }
}
