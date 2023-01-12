namespace MyUniversity;

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public override bool Equals(object? obj)
        {
        if (obj == null)
        {
                return false;
            }
            else
            {
                Person? p = obj as Person;
                return (FirstName == p.FirstName) && (LastName == p.LastName);
            }
        }
    }

