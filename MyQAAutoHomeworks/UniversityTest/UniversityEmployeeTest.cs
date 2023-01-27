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
            UniversityEmployee u = new UniversityEmployee (new Person("Irina","Khrol"),-1234);
        }

        [TestMethod]
        public void CheckMatchTaxIdPositive()
        {
            UniversityEmployee u = new UniversityEmployee(new Person("Irina", "Khrol"), 1234);

            UniversityEmployee u1 = new UniversityEmployee(new Person("Olga", "Khrol"), 1234);

            Assert.IsTrue(u.Equals(u1));
        }

        [TestMethod]
        public void CheckMatchTaxIdNegative()
        {
            UniversityEmployee u = new UniversityEmployee(new Person("Irina", "Khrol"), 1234);

            UniversityEmployee u1 = new UniversityEmployee(new Person("Olga", "Khrol"), 1235);

            Assert.IsFalse(u.Equals(u1));
        }

        [TestMethod]
        public void CompareToTestPositive()
        {;
            UniversityEmployee e1 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            UniversityEmployee e2 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            Assert.AreEqual(0,e1.CompareTo(e2));
        }

        [TestMethod]
        public void CompareToTestPositive2()
        {
            ;
            UniversityEmployee e1 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            UniversityEmployee e2 = new UniversityEmployee(new Person("Irina", "Khroll"), 4321);

            Assert.AreEqual(+1, e1.CompareTo(e2));
        }

        [TestMethod]
        public void CompareToTestNegative()
        {
            ;
            UniversityEmployee e1 = new UniversityEmployee(new Person("Irina", "Khroll"), 4321);

            UniversityEmployee e2 = new UniversityEmployee(new Person("Irina", "Khrol"), 4321);

            Assert.AreEqual(-1, e1.CompareTo(e2));
        }
    }
}
