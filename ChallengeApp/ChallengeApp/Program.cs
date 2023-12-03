string name = "Ewa";
string sex = "Kobieta";
int wiek = 20;

if (wiek < 30 && sex == "Kobieta")
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (wiek == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "Mezczezna" && wiek < 18)
{
    Console.WriteLine("Nepelnoletni mezczyzna");
}