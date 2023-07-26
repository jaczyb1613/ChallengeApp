namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollecetSetsOfPoints_ShouldReturnCorrectResult()
        {
            var employee1 = new Employee("Jacek", "Zybaczynski", 33);
            employee1.AddScore(5);
            employee1.AddScore(5);
            employee1.AddScore(3);
            employee1.AddScore(8);
            employee1.AddScore(5);

            var result = employee1.Result;

            Assert.AreEqual(26, result);
        }
        [Test]
        public void WhenEmployeeCollectedAndLostSetsOfPoints_ShouldReturnCorrectResult()
        {
            var employee2 = new Employee("Kamil", "Kolodziejczyk", 33);
            employee2.AddScore(2);
            employee2.AddScore(1);
            employee2.SubtractScore(-5);
            employee2.AddScore(5);
            employee2.AddScore(2);

            var result = employee2.Result;

            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmployeeCollectSetsOfPointsAndLoseOneSet_ShouldReturnCorrectResult()
        {
            var employee3 = new Employee("Artur", "Nowak", 33);
            employee3.AddScore(1);
            employee3.AddScore(4);
            employee3.AddScore(2);
            employee3.AddScore(3);
            employee3.SubtractScore(-6);

            var result = employee3.Result;

            Assert.AreEqual(4, result);
        }
    }
}