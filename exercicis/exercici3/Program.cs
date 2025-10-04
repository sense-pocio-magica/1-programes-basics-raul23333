namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string nomP = "Tablet";
        int preu = 200;
        bool estoc = true;

        Console.WriteLine("Nom producte: " + nomP);
        Console.WriteLine("Preu: " + preu + "$");
        if (estoc == true)
        {
            Console.WriteLine("Estoc: Disponible");
        }
        else
        {
            Console.WriteLine("Estoc: No disponible");
        }
        
    }
}
