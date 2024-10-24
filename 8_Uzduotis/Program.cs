Console.WriteLine("Iveskite skaiciu");

int skaicius = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    int sandauga = skaicius * i;
    if (sandauga == 50)
    {
        continue;
    }
    Console.WriteLine(sandauga);
}