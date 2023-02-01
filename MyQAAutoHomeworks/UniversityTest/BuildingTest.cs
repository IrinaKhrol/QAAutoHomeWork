using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class BuildingTest
    {
        [TestMethod]
        public void CheckMatchAddressPositive()
        {
            var b = new Building();
            b.Address = "1420, Minsk, office2";

            var b1 = new Building();
            b1.Address = "1420, Minsk, office2";

            Assert.IsTrue(b.Equals(b1));
            Assert.AreEqual(b.GetHashCode(), b1.GetHashCode());
        }

        [TestMethod]
        public void CheckMatchAddressNegative()
        {
            var b = new Building();
            b.Address = "1420, Minsk, office2";

            var b1 = new Building();
            b1.Address = "1421, Minsk, office3";

            Assert.IsFalse(b.Equals(b1));
        }
    }
}
