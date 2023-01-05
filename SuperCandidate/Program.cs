namespace SuperCandidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subjectScore1 = new SubjectScore ("Math", 100);
            var subjectScore2 = new SubjectScore("Phyth", 10);
            Address address1 = new Address("Minsk", "Zyba", 25, 4);
            Candidate candidate1 = new Candidate(new Person("Ivan", "Ivanovich", new Address("Minsk", "Zyba", 25, 4)),
                                                 new SubjectScore[] { subjectScore1, subjectScore2 });

 
            Console.WriteLine(candidate1.Person.LastName);
        }
    }
}