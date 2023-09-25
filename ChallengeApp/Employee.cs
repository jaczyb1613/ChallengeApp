namespace ChallengeApp
{
    public class Employee
    {
        private List<float> Scores = new List<float>();
   
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
      
        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public void AddScore(float score)
        {
           
            if(score >= 0 && score <= 100)  
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
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var score in this.Scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.Scores.Count;

            return statistics;
        }
    }
}