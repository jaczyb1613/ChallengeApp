namespace ChallengeApp
{
    public class Employee
    {
        private List<float> Scores = new List<float>();
        public Employee(string name)
        {
            this.Name = name;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname= surname;  
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public void AddScore(float score)
        {
            this.Scores.Add(score);
        }
        public void SubtractScore(float score)
        {
            this.Scores.Add(score);
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
