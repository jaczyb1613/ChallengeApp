namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        
          public string Name { get; private set; }
          public string Surname { get; private set; }
        
        public abstract void AddScore(float scores);
        public abstract void AddScore(string scores);
        public abstract void Addscore(int scores);
        public abstract void Addscore(double scores);
        public abstract void Addscore(char scores);
        public abstract void Addscore(long scores);
        public abstract Statistics GetStatistics();
       
    }
}
