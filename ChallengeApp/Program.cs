using ChallengeApp;

Console.WriteLine("Witamy w programie Employees ByJack do oceny pracowników");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną liczbę w zakresie od 0 do 100: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddScore(input);
}

var statictics = employee.GetStatistics();
Console.WriteLine("Poniżej wyniki: Średnia, Najmniejsza i największa liczba:");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"Średnia z ocen: {statictics.Average:N2}");
Console.WriteLine($"Najniższa podana liczba: {statictics.Min}");
Console.WriteLine($"Najwyższa podana liczba: {statictics.Max}");

