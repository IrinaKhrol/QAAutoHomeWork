﻿using MyUniversity;

namespace UniversityTest
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void CheckNumberPositive()
        {
            var r = new Room("Lection", 1);
            Assert.AreEqual(1, r.Number);
        }

        [TestMethod]
        public void CheckNumberNegative1()
        {
            var r = new Room("Lection", -1);
            Assert.AreEqual(0, r.Number);
        }

        [TestMethod]
        public void CheckNumberNegative2()
        {
            var r = new Room("Lection", 9999);
            Assert.AreEqual(9999, r.Number);
        }
    }
}
