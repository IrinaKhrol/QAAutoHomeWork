using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class BuildingTest
    {
        [TestMethod]
        public void CheckMatchAddressPositive()
        {
            Building b = new Building();
            b.Address = "1420, Minsk, office2";

            Building b1 = new Building();
            b1.Address = "1420, Minsk, office2";

            Assert.IsTrue(b.Equals(b1));
        }

        [TestMethod]
        public void CheckMatchAddressNegative()
        {
            Building b = new Building();
            b.Address = "1420, Minsk, office2";

            Building b1 = new Building();
            b1.Address = "1421, Minsk, office3";

            Assert.IsFalse(b.Equals(b1));
        }
    }
}
