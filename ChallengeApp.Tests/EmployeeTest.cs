using ChallengeApp;

public class EmployeeTests
{
    [Test]

    public void WhenStaticticsIsCalled_ShouldReturnCorrectMax()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore('A');
        employee.AddScore('B');
        employee.AddScore('C');
        employee.AddScore('D');
        employee.AddScore('E');
        

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual(100 ,statisctics.Max);
    }

    [Test]
    public void WhenStaticticsIsCalled_ShouldReturnCorrectMin()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore('A');
        employee.AddScore('B');
        employee.AddScore('C');
        employee.AddScore('D');
        employee.AddScore('E');

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual(20, statisctics.Min);
    }
    [Test]

    public void WhenStaticticsIsCalled_ShouldReturnCorrectAverage()
    {
        // Arrange

        var employee = new Employee("Jacek", "Zybaczynski");
        employee.AddScore('A');
        employee.AddScore('B');
        employee.AddScore('C');
        employee.AddScore('D');
        employee.AddScore('E');

        // Act

        var statisctics = employee.GetStatistics();

        // Assert

        Assert.AreEqual('C' , statisctics.AverageLetter);
    }
}

