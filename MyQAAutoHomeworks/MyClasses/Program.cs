namespace MyClasses;
internal class Program
{
    static void Main(string[] args)
    {
        // Candidate1 initialization
        var subjectScore1 = new SubjectScore("Math", 10);
        var subjectScore2 = new SubjectScore("Phyth", 5);
        var address1 = new Address("Minsk", "Zybitskaya", 25, 4);
        var person1 = new Person("Ivan", "Ivanovich", address1);
        List<SubjectScore> subjectScores1 = new List<SubjectScore> {
            subjectScore1, 
            subjectScore2 
        };
        Candidate candidate1 = new Candidate(person1, subjectScores1);

        // Candidate2 initialization
        var subjectScore1_1 = new SubjectScore("Math", 9);
        var subjectScore2_2 = new SubjectScore("Phyth", 7);
        var address2 = new Address("Brest", "Volnyay", 10, 23);
        var person2 = new Person("Igor", "Igorevich", address2);
        List<SubjectScore> subjectScores2 = new List<SubjectScore> {
            subjectScore1_1,
            subjectScore2_2
        };
        Candidate candidate2 = new Candidate(person2, subjectScores2);

        // Candidate3 initialization
        var subjectScore1_3 = new SubjectScore("Math", 8);
        var subjectScore2_3 = new SubjectScore("Phyth", 2);
        var address3 = new Address("Gomel", "Kirova", 10, 23);
        var person3 = new Person("Lena", "Elenovna", address3);
        List<SubjectScore> subjectScores3 = new List<SubjectScore> {
            subjectScore1_3,
            subjectScore2_3
        };
        Candidate candidate3 = new Candidate(person3, subjectScores3);

        // Candidate4 initialization
        var subjectScore1_4 = new SubjectScore("Math", 7);
        var subjectScore2_4 = new SubjectScore("Phyth", 7);
        var address4 = new Address("Gomel", "Dobraya", 30, 63);
        var person4 = new Person("Alex", "Alekseevich", address4);
        List<SubjectScore> subjectScores4 = new List<SubjectScore> { subjectScore1_4, subjectScore2_4 };
        Candidate candidate4 = new Candidate(person4, subjectScores4);

        // Candidate5 initialization
        var subjectScore1_5 = new SubjectScore("Math", 4);
        var subjectScore2_5 = new SubjectScore("Phyth", 9);
        var address5 = new Address("Minsk", "Kotrepovo", 45, 10);
        var person5 = new Person("Ivan", "Forotovich", address5);
        List<SubjectScore> subjectScores5 = new List<SubjectScore> { subjectScore1_5, subjectScore2_5 };
        Candidate candidate5 = new Candidate(person5, subjectScores5);

        // Create list of 5 candidates
        List<Candidate> candidateInfos = new List<Candidate>
        {
            candidate1,
            candidate2,
            candidate3,
            candidate4,
            candidate5,
        };

        int maxScore = 0;
        string subjectName = "Phyth";
        Candidate? candidateWithMaxScore = null;

        foreach (Candidate candidate in candidateInfos)
        {
            // Display all streets
            Console.WriteLine("street: " + candidate.Person.Address.Street);

            for (int i = 0; i < candidate.SubjectScores.Count; i++)
            {
                // Find the maximum score for the one of the subjects
                if (candidate.SubjectScores[i].SubjectName == subjectName && maxScore < candidate.SubjectScores[i].Score)
                {
                    maxScore = candidate.SubjectScores[i].Score;
                    candidateWithMaxScore = candidate;
                    break;
                }
            }
        }

        Console.WriteLine("Max Score: " + maxScore);
        Console.WriteLine("Candidate with Max Score: " + candidateWithMaxScore?.Person.LastName);
    }

}
