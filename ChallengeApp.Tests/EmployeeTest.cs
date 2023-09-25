using ChallengeApp;

public class EmployeeTests
{
    [Test]

    public void WhenStaticticsIsCalled_ShouldReturnCorrectMax()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore(8);
        employee.AddScore(3);
        employee.AddScore(5);
        employee.AddScore(8);
        employee.AddScore(3);
        employee.AddScore(5);

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual(8, statisctics.Max);


    }
    [Test]

    public void WhenStaticticsIsCalled_ShouldReturnCorrectMin()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore(384728);
        employee.AddScore(737364);
        employee.AddScore(646474);
        employee.AddScore(293948);
        employee.AddScore(3598585);
        employee.AddScore(5484848);

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual(293948, statisctics.Min);
    }
    [Test]

    public void WhenStaticticsIsCalled_ShouldReturnCorrectAverage()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore(60);
        employee.AddScore(80);
        employee.AddScore(200);
        employee.AddScore(100);
        employee.AddScore(2);
        employee.AddScore(20);

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual(77, statisctics.Average);
    }
}

