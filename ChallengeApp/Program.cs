using ChallengeApp;

Employee employee1 = new Employee("Jacek", " Zybaczynski ");

employee1.AddScore("9");
employee1.AddScore("Jacek");
employee1.AddScore(4344);
employee1.AddScore(3);
employee1.AddScore(5);

var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
