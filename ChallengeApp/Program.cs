var name = "Ewa";
var age = 33;
bool women = true;
if (name == "Ewa" && age == 33 && women == true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (women == true && age < 30)

{ 
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (women == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
    

        