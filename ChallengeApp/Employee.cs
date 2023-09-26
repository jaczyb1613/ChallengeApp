using static System.Formats.Asn1.AsnWriter;

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
        public Statistics GetStatisticsWithForEach()
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

            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var i = 0; i<Scores.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, Scores[i]);
                statistics.Min = Math.Min(statistics.Min, Scores[i]);
                statistics.Average += Scores[i];
            }
            statistics.Average /= this.Scores.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            var index = 0;
            
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.Scores[index]);
                statistics.Min = Math.Min(statistics.Min, this.Scores[index]);
                statistics.Average += this.Scores[index];
                index++;
            
            } while (index < this.Scores.Count);
            
            statistics.Average /= this.Scores.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            var index = 0;

            while (index < this.Scores.Count) 
            {
                statistics.Max = Math.Max(statistics.Max, this.Scores[index]);
                statistics.Min = Math.Min(statistics.Min, this.Scores[index]);
                statistics.Average += this.Scores[index];
                index++;
            } 

            statistics.Average /= this.Scores.Count;
            return statistics;
        }
    }
}