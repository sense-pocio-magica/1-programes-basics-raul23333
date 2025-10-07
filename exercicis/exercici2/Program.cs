namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        string carrer = "Carrer Dels Tapers";
        int num = 1;
        int post = 17707;
        string pob = "Agullana";

        Console.WriteLine($"{carrer} número {num}, {post}, {pob}");
    }
}
