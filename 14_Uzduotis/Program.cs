// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite teigiama skaiciu");

int skaicius = int.Parse(Console.ReadLine());
int skaitmenys = 0;
while (skaicius >= 1)
{
    skaitmenys++;
    skaicius /= 10;
}
Console.WriteLine(skaitmenys);
