// See https://aka.ms/new-console-template for more information)

for (int i = 2; i <= 50; i++)
{
    bool pirminis = true;
    for (int j = 2; j <= Math.Sqrt( i); j++)
	{
		
		if (i % j == 0)
		{
			pirminis = false;	
			break;
		}
	}
    if (pirminis)
    {
        Console.WriteLine(i);
    }
}
