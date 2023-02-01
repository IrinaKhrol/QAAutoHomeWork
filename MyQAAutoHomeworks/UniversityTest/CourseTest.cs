using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CheckMatchNameAndDescriptionPositive()
        {
            var c = new Course("Phyth", "Qvantum Theory");

            var c1 = new Course("Phyth", "Qvantum Theory");

            Assert.IsTrue(c.Equals(c1));
            Assert.AreEqual(c.GetHashCode(), c1.GetHashCode());
        }

        [TestMethod]
        public void CheckMatchNameAndDescriptionNegative1()
        {
            var c = new Course("Phyth", "Qvantum Theory");

            var c1 = new Course("Math", "Qvantum Theory");

            Assert.IsFalse(c.Equals(c1));
        }

        [TestMethod]
        public void CheckMatchNameAndDescriptionNegative2()
        {
            var c = new Course("Phyth", "Qvantum Theory");

            var c1 = new Course("Phyth", "Biology");

            Assert.IsFalse(c.Equals(c1));
        }
    }
}
