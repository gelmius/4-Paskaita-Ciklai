// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite skaiciu");
int skaicius = int .Parse(Console.ReadLine());

for (int i = 1; i < skaicius+1; i++)
{
    int kvadratas = i * i;
    Console.WriteLine(kvadratas);
    if (kvadratas > 200)
    {
        break;
    }
}
