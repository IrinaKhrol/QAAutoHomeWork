namespace MyClasses
{
    internal class SubjectScore
    {
        private const int Max_Score = 10;
        private int _score;
        public string SubjectName { get; set; }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 0 && value <= Max_Score)
                {
                    _score = value;
                }
            }
        }
        public SubjectScore(string subjectName, int score)
        {
            SubjectName = subjectName;
            Score = score;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                SubjectScore? s = obj as SubjectScore;
                return (SubjectName == s.SubjectName) && (Score == s.Score);
            }
}   }     }
