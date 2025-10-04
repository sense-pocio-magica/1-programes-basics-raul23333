namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quants metres: ");
        int metres = Convert.ToInt16(Console.ReadLine());

        double peus = 3.28084;
        double valor = metres * peus;

        Console.WriteLine($"{metres} metres = {valor} peus");

    }
}
