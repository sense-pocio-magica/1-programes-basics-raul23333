namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Preu en euros: ");

        double eur = double.Parse(Console.ReadLine());
        double pessetes = 166.386;
        double res = eur * pessetes;

        Console.WriteLine($"El producte costa {res} pessetes");
    }
}
