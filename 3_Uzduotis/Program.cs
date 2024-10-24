// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("iveskite skaiciu");
    int x = int.Parse(Console.ReadLine());
    switch (x)
    {
        case int n when (n % 2 == 0):
            Console.WriteLine("Dalynasi is dvieju");
            break;
        default:
            Console.WriteLine("Nesidalina is dvieju");
            break;
    }
}
