//Sukurkite programą, kuri naudoja while ciklą, kad sugeneruotų atsitiktinius skaičius nuo 1 iki 10. Programa turi sustoti, kai sugeneruojamas skaičius 7, ir parodyti, kiek kartų buvo sugeneruoti skaičiai iki tol.



Random r = new Random();
int x = r.Next(1, 10);
while (x != 7)
{
    Console.WriteLine(x);
    x = r.Next(1, 10);
}
