using static System.Formats.Asn1.AsnWriter;

namespace MyClasses
{
     internal class Candidate
    {
        public Person Person { get; set; }
        public List <SubjectScore> SubjectScores { get; set; }

        public Candidate (Person person, List<SubjectScore> subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Candidate? c = obj as Candidate;
                return (Person == c.Person) && (SubjectScores == c.SubjectScores);
            }
}    }  }
