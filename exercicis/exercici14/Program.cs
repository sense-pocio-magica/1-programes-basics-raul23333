namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        string paraula = "Patata";
        char pri = paraula[0];
        char mig = paraula[2];
        char ult = paraula[5];
        Console.WriteLine($"{pri} {mig} {ult}");
    }
}
