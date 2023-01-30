using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CheckLengthFullNamePositive()
        {
            var p = new Person("Irinaaaaaa", "Khrollllll");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckLengthFullNameNegative()
        {
            var p = new Person("Irinaaaaaaa", "Khrolllllll");
        }


        [TestMethod]
        public void CheckMatchLastNameFirstNamePositive() 
        {
            var p = new Person("Vasilii", "Pupkin");

            var p1 = new Person("Vasilii", "Pupkin");

            Assert.IsTrue(p.Equals(p1));
            Assert.AreNotEqual(p.GetHashCode, p1.GetHashCode());
        }

        [TestMethod]
        public void CheckMatchLastNameFirstNameNegative1()
        {
            var p = new Person("Vasilii", "Pupkin");

            var p2 = new Person("Igor", "Pupkin");

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void CheckMatchLastNameFirstNameNegative2()
        {
            var p = new Person("Vasilii", "Pupkin");

            var p2 = new Person("Vasilii", "Govorun");

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChekFirstNameandLastNameNegative()
        {
            var u = new UniversityEmployee(new Person(null, "Khrol"), 1234);
        }
    }
}