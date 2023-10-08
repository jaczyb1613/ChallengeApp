namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {

        private List<float> Scores = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

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
        public void AddScore(string scores)
        {
            throw new Exception();
        }
        public void AddScores(string score)
        {
            switch (score)
            {
                case "6":
                    this.AddScore(100);
                    break;
                case "6-":
                case "-6":
                    this.AddScore(95);
                    break;
                case "5":
                    this.AddScore(80);
                    break;
                case "+5":
                case "5+":
                    this.AddScore(85);
                    break;
                case "-5":
                case "5-":
                    this.AddScore(75);
                    break;
                case "4":
                    this.AddScore(60);
                    break;
                case "+4":
                case "4+":
                    this.AddScore(65);
                    break;
                case "-4":
                case "4-":
                    this.AddScore(55);
                    break;
                case "3":
                    this.AddScore(40);
                    break;
                case "+3":
                case "3+":
                    this.AddScore(45);
                    break;
                case "-3":
                case "3-":
                    this.AddScore(35);
                    break;
                case "2":
                    this.AddScore(20);
                    break;
                case "+2":
                case "2+":
                    this.AddScore(25);
                    break;
                case "-2":
                case "2-":
                    this.AddScore(15);
                    break;
                case "1":
                    this.AddScore(0);
                    break;
                case "+1":
                case "1+":
                    this.AddScore(5);
                    break;
                case "-1":
                case "1-":
                    this.AddScore(0);
                    break;
                default:
                    throw new Exception("Invalid data provide, please try again");
                    break;
            }
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

