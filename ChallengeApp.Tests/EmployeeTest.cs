namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollecetSetsOfPoints_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Jacek", "Zybaczynski", 33);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(5);

            var result = employee.Result;

            Assert.AreEqual(26, result);
        }
        [Test]
        public void WhenEmployeeCollectedAndLostSetsOfPoints_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Kamil", "Kolodziejczyk", 33);
            employee.AddScore(2);
            employee.AddScore(1);
            employee.SubtractScore(-5);
            employee.AddScore(5);
            employee.AddScore(2);

            var result = employee.Result;

            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmployeeCollectSetsOfPointsAndLoseOneSet_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Artur", "Nowak", 33);
            employee.AddScore(1);
            employee.AddScore(4);
            employee.AddScore(2);
            employee.AddScore(3);
            employee.SubtractScore(-6);

            var result = employee.Result;

            Assert.AreEqual(4, result);
        }
    }
}