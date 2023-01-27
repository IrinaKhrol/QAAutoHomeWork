using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class UniversityTest
    {

        [TestMethod]
        public void AddTestNegative()
        {
            var university1 = new University();
            Building b1 = new Building();
            b1.Address = "1420, Minsk, office2";

            Building b2 = new Building();
            b2.Address = "1420, Minsk, office3";

            var buildings = new List<Building> { b1, b2,};
            university1.Buildings = buildings;

            Assert.AreEqual(false, university1.Add(b1, university1.Buildings));
        }

        [TestMethod]
        public void AddTestPositive()
        {
            var university1 = new University();
            Building b1 = new Building();
            b1.Address = "1420, Minsk, office2";

            Building b2 = new Building();
            b2.Address = "1420, Minsk, office3";

            Building b3 = new Building();
            b3.Address = "1235, Minsk, office4";

            var buildings = new List<Building> { b1, b2, };
            university1.Buildings = buildings;

            Assert.AreEqual(true, university1.Add(b3, university1.Buildings));
        }
    }
}
