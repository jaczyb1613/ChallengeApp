using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class Employee
    {
        private readonly char sex = 'M';
        private List<float> Scores = new List<float>();
        public Employee()
        {
            this.Name = "";

        }
        public Employee(string name)
        {
            this.Name = name;

        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.sex = 'K';
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public void AddScore(float score)
        {

            if (score >= 0 && score <= 100)
            {
                this.Scores.Add(score);
            }
            else
            {
                throw new Exception("Invalid score value");
            }

        }
        public void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public void Addscore(int score)
        {
            float scoreToInt = (int)score;
            this.AddScore(scoreToInt);
        }
        public void Addscore(double score)
        {
            float scoreToFloat = (float)score;
            this.AddScore(scoreToFloat);
        }
        public void Addscore(long score)
        {
            float scoreToLong = (long)score;
            this.AddScore(scoreToLong);
        }
        public void Addscore(char score)
        {
            float scoreToChar = (char)score;
            this.AddScore(scoreToChar);
        }
        public void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.Addscore(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(20);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.Scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.Scores.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}