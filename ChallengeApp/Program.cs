using ChallengeApp;

Employee employee1 = new Employee("Jacek", " Zybaczynski ");
Employee employee2 = new Employee("kamil", " kolodziejczyk");
Employee employee3 = new Employee("Artur", " Nowak ");

employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(1);
employee1.AddScore(3);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(2);

employee3.AddScore(60);
employee3.AddScore(80);
employee3.AddScore(200);
employee3.AddScore(100);
employee3.AddScore(2);
employee3.AddScore(20);

var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics2 = employee2.GetStatistics();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee3.GetStatistics();
Console.WriteLine($"Average: {statistics3.Average:N2}");