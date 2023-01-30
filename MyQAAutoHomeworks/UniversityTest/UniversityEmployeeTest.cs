using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class UniversityEmployeeTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChekTaxIdNegative()
        {
            var u = new UniversityEmployee (new Person("Irina","Khrol"),-1234);
        }

        [TestMethod]
        public void CheckMatchTaxIdPositive()
        {
            var u = new UniversityEmployee(new Person("Irina", "Khrol"), 1234);

            var u1 = new UniversityEmployee(new Person("Olga", "Khrol"), 1234);

            Assert.IsTrue(u.Equals(u1));
        }

        [TestMethod]
        public void CheckMatchTaxIdNegative()
        {
            var u = new UniversityEmployee(new Person("Irina", "Khrol"), 1234);

            var u1 = new UniversityEmployee(new Person("Olga", "Khrol"), 1235);

            Assert.IsFalse(u.Equals(u1));
        }

        [TestMethod]
        public void CompareToTestPositive()
        {
            var e1 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            var e2 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            Assert.AreEqual(0,e1.CompareTo(e2));
            Assert.AreNotEqual(e1.GetHashCode, e2.GetHashCode());
        }

        [TestMethod]
        public void CompareToTestPositive2()
        {
            var e1 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            var e2 = new UniversityEmployee(new Person("Irina", "Khroll"), 4321);

            Assert.IsTrue(e1.CompareTo(e2) > 0);
        }

        [TestMethod]
        public void CompareToTestPositive3()
        {
            var e1 = new UniversityEmployee(new Person("Irina", "Khroll"), 4321);

            var e2 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            Assert.IsTrue(e1.CompareTo(e2) < 0);
        }
    }
}
