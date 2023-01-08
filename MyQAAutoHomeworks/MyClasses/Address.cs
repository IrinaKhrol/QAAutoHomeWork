namespace MyClasses
{
     internal class Address
    {
        private const int Max_Home_Number = 1000;
        private const int Max_Flat_Number = 10_100;
        private int _home;
        private int _flat;
        public string City { get; set; }
        public string Street { get; set; }
        public int Home 
        {
            get
            {
                return _home;
            }
            set
            {
                if (value > 0 && value < Max_Home_Number)
                {
                    _home = value;
                }
            }
        }
        public int Flat
        {
            get
            {
                return _flat;
            }
            set
            {
                if (value > 0 && value < Max_Flat_Number)
                {
                    _flat = value;
                }
            }
        }
        public Address(string city, string street, int home, int flat)
        {
            City = city;
            Street = street;
            Home = home;
            Flat = flat;
        }
    }   
}
