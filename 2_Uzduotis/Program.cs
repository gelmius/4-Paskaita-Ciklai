// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite 3 skaicius");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
int didziausias = x1;
for (int i = 2; i <= 3; i++)
{
    if (i == 2 && x2 > didziausias)
    {
        didziausias = x2;
    }

    if (i == 3 && x3 > didziausias)
    {
        didziausias = x3;
    }
}

