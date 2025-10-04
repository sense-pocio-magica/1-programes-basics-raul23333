namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        try
        {
            string paraula = "Hola";
            int longpar = paraula.Length;
            Console.WriteLine($"La paraula {paraula} conté {longpar} caràcters");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}