// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite pradzios skaiciu ir priaugi ir norima progresijos ilgi");

int skaicius = int.Parse(Console.ReadLine());
int prieugis = int.Parse(Console.ReadLine());
int ilgis = int.Parse(Console.ReadLine());

skaicius += prieugis;
for (int i = 0; i < ilgis; i++)
{

    int progresija = skaicius + i * prieugis;

    if (progresija > 100)
    {        
        break;
    }

    Console.WriteLine(progresija);
}

