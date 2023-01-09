using System;

namespace MyUniversityActive
{
    internal class Staff
    {
        public string StaffName { get; set; }
        public string Duties { get; set; }

        public Staff(string staffName, string duties)
        {
            StaffName = staffName;
            Duties = duties;
        }
    }
}
