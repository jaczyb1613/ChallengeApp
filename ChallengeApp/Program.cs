using ChallengeApp;

Employee employee = new Employee("Jacek", " Zybaczynski ");

employee.AddScore("9");
employee.AddScore(4);
employee.AddScore(45);
employee.AddScore(1);
employee.AddScore("3");

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Pętla ForEach:");
Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("Pętla For:");
Console.WriteLine($"Average: {statistics2.Average}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("Pętla While:");
Console.WriteLine($"Average: {statistics3.Average}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine("Pętla DoWhile:");
Console.WriteLine($"Average: {statistics4.Average}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
