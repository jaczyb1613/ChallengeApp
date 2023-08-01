namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScoresShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "Zybaczynski", 33);
            employee.AddScore(1);
            employee.AddScore(2);
            employee.AddScore(6);
            employee.AddScore(8);
            
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(1, statistics.Min);
        
        }
        [Test]
        public void WhenEmployeeCollectSameScoresShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "Zybaczynski", 33);
            employee.AddScore(3);
            employee.AddScore(3);
            employee.AddScore(3);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Average);
          
        }
    }
}