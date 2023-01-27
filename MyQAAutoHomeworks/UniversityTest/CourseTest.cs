using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CheckMatchNameAndDescriptionPositive()
        {
            Course c = new Course("Phyth", "Qvantum Theory");

            Course c1 = new Course("Phyth", "Qvantum Theory");

            Assert.IsTrue(c.Equals(c1));
        }

        [TestMethod]
        public void CheckMatchNameAndDescriptionNegative1()
        {
            Course c = new Course("Phyth", "Qvantum Theory");

            Course c1 = new Course("Math", "Qvantum Theory");

            Assert.IsFalse(c.Equals(c1));
        }

        [TestMethod]
        public void CheckMatchNameAndDescriptionNegative2()
        {
            Course c = new Course("Phyth", "Qvantum Theory");

            Course c1 = new Course("Phyth", "Biology");

            Assert.IsFalse(c.Equals(c1));
        }
    }
}
