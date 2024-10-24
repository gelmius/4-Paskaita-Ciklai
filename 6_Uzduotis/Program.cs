// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sugeneruojam 10 skaiciu ir isvedam i ekrana tik lyginius");

Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    int x = rnd.Next(1,51);
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
}
