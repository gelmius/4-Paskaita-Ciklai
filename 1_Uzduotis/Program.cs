// See https://aka.ms/new-console-template for more information
int skaicius = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iveskite skaiciu");
    skaicius = int.Parse(Console.ReadLine());
    if (skaicius > 0)
    {
        Console.WriteLine("Skaicius teigiamas");
    }
    else
    {
        Console.WriteLine("Skaicius neigiamas");
    }
}
