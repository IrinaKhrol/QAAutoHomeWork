namespace MyClasses
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Candidate1 initialization
            var subjectScore1 = new SubjectScore("Math", 10);
            var subjectScore2 = new SubjectScore("Phyth", 5);
            Address address1 = new Address("Minsk", "Zybitskaya", 25, 4);
            Person person1 = new Person("Ivan", "Ivanovich", address1);
            SubjectScore[] subjectScores1 = new SubjectScore[] { subjectScore1, subjectScore2 };
            Candidate candidate1 = new Candidate(person1, subjectScores1);

            // Candidate2 initialization
            var subjectScore1_1 = new SubjectScore("Math", 9);
            var subjectScore2_2 = new SubjectScore("Phyth", 7);
            Address address2 = new Address("Brest", "Volnyay", 10, 23);
            Person person2 = new Person("Igor", "Igorevich", address2);
            SubjectScore[] subjectScores2 = new SubjectScore[] { subjectScore1_1, subjectScore2_2 };
            Candidate candidate2 = new Candidate(person2, subjectScores2);

            // Candidate3 initialization
            var subjectScore1_3 = new SubjectScore("Math", 8);
            var subjectScore2_3 = new SubjectScore("Phyth", 2);
            Address address3 = new Address("Gomel", "Kirova", 10, 23);
            Person person3 = new Person("Lena", "Elenovna", address3);
            SubjectScore[] subjectScores3 = new SubjectScore[] { subjectScore1_3, subjectScore2_3 };
            Candidate candidate3 = new Candidate(person3, subjectScores3);

            // Candidate4 initialization
            var subjectScore1_4 = new SubjectScore("Math", 7);
            var subjectScore2_4 = new SubjectScore("Phyth", 7);
            Address address4 = new Address("Gomel", "Dobraya", 30, 63);
            Person person4 = new Person("Alex", "Alekseevich", address4);
            SubjectScore[] subjectScores4 = new SubjectScore[] { subjectScore1_4, subjectScore2_4 };
            Candidate candidate4 = new Candidate(person4, subjectScores4);

            // Candidate5 initialization
            var subjectScore1_5 = new SubjectScore("Math", 4);
            var subjectScore2_5 = new SubjectScore("Phyth", 9);
            Address address5 = new Address("Minsk", "Kotrepovo", 45, 10);
            Person person5 = new Person("Ivan", "Forotovich", address5);
            SubjectScore[] subjectScores5 = new SubjectScore[] { subjectScore1_5, subjectScore2_5 };
            Candidate candidate5 = new Candidate(person5, subjectScores5);

            // Create array of 5 candidates
            Candidate[] candidateInfos = new Candidate[5];
            candidateInfos[0] = candidate1;
            candidateInfos[1] = candidate2;
            candidateInfos[2] = candidate3;
            candidateInfos[3] = candidate4;
            candidateInfos[4] = candidate5;

            int maxScore = 0;
            string subjectName = "Phyth";
            Candidate candidateWithMaxScore = candidate1;

            foreach (Candidate candidate in candidateInfos)
            {
                // Display all streets
                Console.WriteLine("street: " + candidate.Person.Address.Street);

                for (int i = 0; i < candidate.SubjectScores.Length; i++)
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
            Console.WriteLine("Candidate with Max Score: " + candidateWithMaxScore.Person.LastName);

        }

    }
}    