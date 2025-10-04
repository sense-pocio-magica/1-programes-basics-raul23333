namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Escriu el teu nom: ");
            string nom = Console.ReadLine();
            Console.Write("Escriu el teu any de naixement: ");
            int any = Convert.ToInt16(Console.ReadLine());
            int edat = 2025 - any;
            Console.WriteLine($"Hola {nom}!  Ja tens {edat} anys?");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}
