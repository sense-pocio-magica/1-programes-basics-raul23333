namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int minuts = 200;
        int minuts2 = minuts % 60;
        int hores = minuts / 60;
        Console.WriteLine($"Hores = {hores} Minuts = {minuts2}");
    }
}
