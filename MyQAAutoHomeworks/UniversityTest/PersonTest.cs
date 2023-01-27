using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CheckLengthFullNamePositive()
        {
            Person p = new Person("Irinaaaaaa", "Khrollllll");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckLengthFullNameNegative()
        {
            Person p = new Person("Irinaaaaaaa", "Khrollllll");
        }

        [TestMethod]
        public void CheckMatchLastNameFirstNamePositive() 
        {
            Person p = new Person("Vasilii", "Pupkin");

            Person p1 = new Person("Vasilii", "Pupkin");

            Assert.IsTrue(p.Equals(p1));
        }

        [TestMethod]
        public void CheckMatchLastNameFirstNameNegative1()
        {
            Person p = new Person("Vasilii", "Pupkin");

            Person p2 = new Person("Igor", "Pupkin");

            Assert.IsFalse(p.Equals(p2));
        }

        [TestMethod]
        public void CheckMatchLastNameFirstNameNegative2()
        {
            Person p = new Person("Vasilii", "Pupkin");

            Person p2 = new Person("Vasilii", "Govorun");

            Assert.IsFalse(p.Equals(p2));
        }
    }
}