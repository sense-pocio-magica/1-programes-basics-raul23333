namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        double not1 = 10;
        double not2 = 7;
        double not3 = 3.5;

        double mitj = (not1 + not2 + not3) / 3;
        Console.WriteLine($"La mitjana és {mitj}");
    }
}
