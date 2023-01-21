using System.Security.Cryptography.X509Certificates;

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
            (new Person("Olga", "Pen"),
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
            (new Person("Peter", "Isaakov"),
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

        var employee9 = new Teacher
            (new Person("Misha", "Ivanov"),
            0101,
            new Course("Phyth", "Qvantum Theory"));

        var universityEmployees = new List<UniversityEmployee>
        {
            employee1,
            employee2,
            employee3,
            employee4,
            employee5,
            employee6,
            employee7,
            employee9
        };

        //Display duties for University Employee and Teacher
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

        static int GetLastName(UniversityEmployee u)
        {
            return u.TaxId;
        }


        var university1 = new University();
        university1.Rector = "Ivan";

        var building1 = new Building();
        building1.Address = "1420, Minsk, office2";
        building1.Cost = 10000000;

        var room1 = new Room("Lection", 1);
        var room2 = new Room("Laboratory", 23);
        List<Room> rooms1 = new List<Room> { room1, room2 };
        building1.rooms = rooms1;

        var building2 = new Building();
        building2.Address = "1420, Minsk, office3";
        building2.Cost = 25000000;

        var room3 = new Room("Lection1", 34);
        var room4 = new Room("Laboratory1", 5);
        List<Room> rooms2 = new List<Room> { room3, room4 };
        building2.rooms = rooms2;

        var building3 = new Building();
        building3.Address = "1555, Minsk, office3";
        building3.Cost = 25000000;

        var room5 = new Room("Lection1", 7);
        var room6 = new Room("Laboratory1", 24);
        List<Room> rooms3 = new List<Room> { room5, room6 };
        building3.rooms = rooms3;

        var building4 = new Building();

        building4.Address = "1234, Grodno, dobry7";

        var room7 = new Room("Lection", 8);
        var room8 = new Room("Laboratiry", 43);
        var room9 = new Room("Seminar", 26);
        List<Room> rooms4 = new List<Room> { room7, room8, room9};
        building4.rooms = rooms4;

        var buildings = new List<Building> { building1, building2, building4 };
        university1.Buildings = buildings;

        // Add building with University.Add<T>(T item, List<T> listitems)
        Console.WriteLine();
        Console.WriteLine("-------------------Building-----------------------------------------");

        foreach (var building in new Building[] { building2, building3 })
        {
            if (university1.Add(building, university1.Buildings))
            {
                Console.WriteLine("New Building has been added");
            }
            else
            {
                Console.WriteLine("New Building has not been added");
            }
        }

        // Add employee with University.Add<T>(T item, List<T> listitems)
        Console.WriteLine();
        Console.WriteLine("-------------------Employee-----------------------------------------");

        university1.UniversityEmployees = universityEmployees;

        foreach (var employee in new UniversityEmployee[] { employee5, employee8 })
        {
            if (university1.Add(employee, university1.UniversityEmployees))
            {
                Console.WriteLine("New Employee has been added");
            }
            else
            {
                Console.WriteLine("New Employee has not been added");
            }
        }

        // Display Rector (object of type University)
        Console.WriteLine();
        Console.WriteLine("-------------------Rector-----------------------------------------");
        Console.WriteLine(university1.Rector);


        // Display all university employees with a last name starting with a certain letter (optional)
        Console.WriteLine();
        Console.WriteLine("-------------------FirstLetterOfLastNameFilter-----------------------------------------");

        var firstLetterOfLastNameFilter = "I";
        var filteredlist = university1.UniversityEmployees.Select(x => (x.Person.LastName, x.TaxId)).Where(x => x.TaxId > 10).Select(x => x.LastName).ToList();

        foreach(var u in filteredlist)
        {
            Console.WriteLine(u);
        }


        //Display all university teachers who teach a specific course
        Console.WriteLine();
        Console.WriteLine("-------------------FilteredTeacherlist-----------------------------------------");

        var courseNameFilter = "Phyth";

        var filteredTeacherlist = university1.UniversityEmployees.OfType<Teacher>().Where(item => item.Course.Name.Equals(courseNameFilter)).ToList();

        foreach (var t in filteredTeacherlist)
        {
            Console.WriteLine(t.Person.FirstName + " " + t.Person.LastName + " " + t.Course.Name.ToString());
        }


        //Display TaxID and job duties of each employee
        Console.WriteLine();
        Console.WriteLine("-------------------TaxWithDuties-----------------------------------------");

        var taxWithDuties = university1.UniversityEmployees.Select(item => item.TaxId.ToString() + " " + item.GetOfficialDuties()).ToList();

        foreach (var u in taxWithDuties)
        {
            Console.WriteLine(u.ToString());
        }


        //Display the addresses of all buildings that have a room with a certain number (optional)
        Console.WriteLine();
        Console.WriteLine("-------------------FilteredBuildingslist-----------------------------------------");

        var roomNumberFilter = 34;

        var filteredBuildingslist = university1.Buildings.Where(item => item.rooms.Any(x => x.Number == roomNumberFilter)).ToList();

        foreach (var b in filteredBuildingslist)
        {
            Console.WriteLine(b.Address);
        }


        //Display the address of the building with the maximum number of rooms in it
        Console.WriteLine();
        Console.WriteLine("-------------------BuildingWithMaxRooms-----------------------------------------");

        var buildingWithMaxRooms = university1.Buildings.MaxBy(item => item.rooms.Count());

        Console.WriteLine(buildingWithMaxRooms.Address);


        //Display the most common employee last name and the number of such employees
        Console.WriteLine();
        Console.WriteLine("-------------------PopularLastName-----------------------------------------");

        var popularLastName = university1.UniversityEmployees.GroupBy(item => item.Person.LastName).MaxBy(item => item.Count());
        Console.WriteLine(popularLastName.Key + " " + popularLastName.Count());
    }
}
