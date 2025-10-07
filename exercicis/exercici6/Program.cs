namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        double quadrat = 5;
        double perimetre = quadrat * 4;
        Console.WriteLine($"El perímetre és {perimetre}");
    }
}
