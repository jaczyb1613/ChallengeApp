using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> Scores = new List<float>();
        public Employee()
        {
            
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
                Console.WriteLine("Invalid score value");
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
                Console.WriteLine("String is not float");
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
        public void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.Scores.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.Scores.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.Scores.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.Scores.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.Scores.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    break;
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

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A'; 
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
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