for (int i = 0; i < 5; i++)
{
    Console.WriteLine("iveskite skaiciu");
    int x = int.Parse(Console.ReadLine());
    switch (x)
    {
        case int n when (n >0 && n <10):
            Console.WriteLine("Mažas");
            break;
        case int n when (n > 10 && n < 100):
            Console.WriteLine("Vidutinis");
            break;
        case int n when (n > 100):
            Console.WriteLine("Didelis");
            break;
        default:
            Console.WriteLine("neigiamas skaicius ");
            break;
    }
}