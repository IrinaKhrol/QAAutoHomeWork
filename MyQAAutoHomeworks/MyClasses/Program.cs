namespace MyClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            // Candidate1 initialization
            Address address1 = new Address("Minsk", "chkalova", 15, 25);

            Person person1 = new Person("Ivan", "Ivanov", address1);

            SubjectScore scoreMath1 = new SubjectScore(90, "Math");

            SubjectScore scorePhysics1 = new SubjectScore(70, "Physics");

            SubjectScore scoreLith1 = new SubjectScore(80, "Lith");

            SubjectScore scoreLanguage1 = new SubjectScore(60, "Language");

            SubjectScore[] subjectScores1 = new SubjectScore[4];
            subjectScores1[0] = scoreMath1;
            subjectScores1[1] = scorePhysics1;
            subjectScores1[2] = scoreLith1;
            subjectScores1[3] = scoreLanguage1;

            CandidateInfo candidate1 = new CandidateInfo(person1, subjectScores1);


            // Candidate2 initialization
            Address address2 = new Address("Minsk", "kirova", 21, 24);

            Person person2 = new Person("Igor", "Igorevich", address2);

            SubjectScore scoreMath2 = new SubjectScore(80, "Math");

            SubjectScore scorePhysics2 = new SubjectScore(77, "Physics");

            SubjectScore scoreLith2 = new SubjectScore(80, "Lith");

            SubjectScore scoreLanguage2 = new SubjectScore(30, "Language");

            SubjectScore[] subjectScores2 = new SubjectScore[4];
            subjectScores2[0] = scoreMath2;
            subjectScores2[1] = scorePhysics2;
            subjectScores2[2] = scoreLith2;
            subjectScores2[3] = scoreLanguage2;

            CandidateInfo candidate2 = new CandidateInfo(person2, subjectScores2);


            // Candidate3 initialization
            Address address3 = new Address("Minsk", "soltysa", 12, 45);

            Person person3 = new Person("Lena", "Elenovna", address3);

            SubjectScore scoreMath3 = new SubjectScore(86, "Math");

            SubjectScore scorePhysics3 = new SubjectScore(70, "Physics");

            SubjectScore scoreLith3 = new SubjectScore(100, "Lith");

            SubjectScore scoreLanguage3 = new SubjectScore(98, "Language");

            SubjectScore[] subjectScores3 = new SubjectScore[4];
            subjectScores3[0] = scoreMath3;
            subjectScores3[1] = scorePhysics3;
            subjectScores3[2] = scoreLith3;
            subjectScores3[3] = scoreLanguage3;

            CandidateInfo candidate3 = new CandidateInfo(person3, subjectScores3);


            // Candidate4 initialization
            Address address4 = new Address("Gomel", "voinao", 36, 20);

            Person person4 = new Person("Alex", "Alekseevich", address4);

            SubjectScore scoreMath4 = new SubjectScore(90, "Math");

            SubjectScore scorePhysics4 = new SubjectScore(99, "Physics");

            SubjectScore scoreLith4 = new SubjectScore(89, "Lith");

            SubjectScore scoreLanguage4 = new SubjectScore(87, "Language");

            SubjectScore[] subjectScores4 = new SubjectScore[4];
            subjectScores4[0] = scoreMath4;
            subjectScores4[1] = scorePhysics4;
            subjectScores4[2] = scoreLith4;
            subjectScores4[3] = scoreLanguage4;

            CandidateInfo candidate4 = new CandidateInfo(person4, subjectScores4);


            // Candidate5 initialization
            Address address5 = new Address("Brest", "stolichnaya", 15, 45);

            Person person5 = new Person("Ivan", "Ivanovich", address5);

            SubjectScore scoreMath5 = new SubjectScore(100, "Math");

            SubjectScore scorePhysics5 = new SubjectScore(100, "Physics");

            SubjectScore scoreLith5 = new SubjectScore(98, "Lith");

            SubjectScore scoreLanguage5 = new SubjectScore(96, "Language");

            SubjectScore[] subjectScores5 = new SubjectScore[4];
            subjectScores5[0] = scoreMath5;
            subjectScores5[1] = scorePhysics5;
            subjectScores5[2] = scoreLith5;
            subjectScores5[3] = scoreLanguage5;

            CandidateInfo candidate5 = new CandidateInfo(person5, subjectScores5);

            // Create array of 5 candidates
            CandidateInfo[] candidateInfos = new CandidateInfo[5];
            candidateInfos[0] = candidate1;
            candidateInfos[1] = candidate2;
            candidateInfos[2] = candidate3;
            candidateInfos[3] = candidate4;
            candidateInfos[4] = candidate5;

            int maxScore = 0;
            string subjectName = "Physics";
            CandidateInfo candidateWithMaxScore = candidate1;

            foreach (CandidateInfo candidate in candidateInfos)
            {
                // Display all streets
                Console.WriteLine("street: " + candidate.personInfo.Address.Street);

                for (int i = 0; i < candidate.subjectScores.Length; i++)
                {
                    // Find the maximum score for the one of the subjects
                    if (candidate.subjectScores[i].SubjectName == subjectName && maxScore < candidate.subjectScores[i].Score)
                    {
                        maxScore = candidate.subjectScores[i].Score;
                        candidateWithMaxScore = candidate;
                        break;
                    }
                }
            }

            Console.WriteLine("Max Score: " + maxScore);
            Console.WriteLine("Candidate with Max Score: " + candidateWithMaxScore.personInfo.LastName);

        }

    }
}    