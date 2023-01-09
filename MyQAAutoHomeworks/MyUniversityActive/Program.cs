namespace MyUniversityActive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var university1 = new University();
            university1.Rector = "Ivan";

            var building1 = new Building();
            building1.Address = "1420, Minsk, office2";
            building1.Cost = 10000000;

            var room1 = new Room("Lection");
            var room2 = new Room("Laboratory");
            Room[] rooms1 = new Room[] { room1, room2 };
            building1.rooms = rooms1;

            var building2 = new Building();
            building2.Address = "1420, Minsk, office3";
            building2.Cost = 25000000;

            var room3 = new Room("Lection1");
            var room4 = new Room("Laboratory1");
            Room[] rooms2 = new Room[] { room3, room4 };
            building2.rooms = rooms2;

            var staff1 = new Staff("Cleaner","Cleanist");
            var staff2 = new Staff("Teacher", "Teach");

            Staff[] staffes = new Staff[] { staff1, staff2 };
            university1.Staffes = staffes;

            Building[] buildings = new Building[] { building1, building2 };
            university1.Buildings = buildings;


            Console.WriteLine(university1.Rector);
            Console.WriteLine(university1.Staffes[0].StaffName);
        }
    }
}