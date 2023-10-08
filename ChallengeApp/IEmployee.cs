namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddScore(float scores);
        void AddScore(string scores);
        void Addscore(int scores);
        void Addscore(double scores);
        void Addscore(char scores);
        void Addscore(long scores);
        Statistics GetStatistics();
    }
}
