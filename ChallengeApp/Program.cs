using ChallengeApp;

Employee employee1 = new Employee("Jacek ", " Zybaczynski ", 33);
Employee employee2 = new Employee("Kamil ", " Kolodziejczyk ", 33);
Employee employee3 = new Employee("Artur ", " Nowak ", 33);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(1);
var result = employee1.Result;
string name = employee1.Name;
string surname = employee1.Surname;
var age = employee1.Age;

employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(2);
var result2 = employee2.Result;
string name2 = employee2.Name;
string surname2 = employee2.Surname;
var age2 = employee2.Age;

employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(1);
var result3 = employee3.Result;
string name3 = employee3.Name;
string surname3 = employee3.Surname;
var age3 = employee2.Age;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;  
        maxResult = employee.Result;
    }
}

Console.WriteLine("Wyniki pracowników: ");
Console.WriteLine(employee1.Name + employee1.Surname + "lat: " + employee1.Age + " wynik: " + employee1.Result);
Console.WriteLine(employee2.Name + employee2.Surname + "lat: " + employee2.Age + " wynik: " + employee2.Result);
Console.WriteLine(employee3.Name + employee3.Surname + "lat: " + employee3.Age + " wynik: " + employee3.Result);
Console.WriteLine("Największy wynik osiągnał pracownik: " + employee1.Name + employee1.Surname + "lat: " + employee1.Age +" wynik: " + maxResult);



