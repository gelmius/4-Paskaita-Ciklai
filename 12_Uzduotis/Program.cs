// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite pradzios skaiciu ir priaugi");
int skaicius = int.Parse(Console.ReadLine());
int prieugis = int.Parse(Console.ReadLine());

skaicius += prieugis;
while (skaicius < 500)
{

    Console.WriteLine(skaicius);
    skaicius += prieugis;
}

