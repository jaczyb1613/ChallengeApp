namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float scores)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(string scores)
        {
            throw new NotImplementedException();
        }

        public override void Addscore(int scores)
        {
            throw new NotImplementedException();
        }

        public override void Addscore(double scores)
        {
            throw new NotImplementedException();
        }

        public override void Addscore(char scores)
        {
            throw new NotImplementedException();
        }

        public override void Addscore(long scores)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
