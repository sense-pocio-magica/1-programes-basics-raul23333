using System;

namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8 
Nota de l’examen: 9    
La nota final és 8.7 o sigui un 9

*/

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nota de pràctiques: ");
            double pra = double.Parse(Console.ReadLine());
            

            Console.Write("Nota de l'examen: ");
            double exa = double.Parse(Console.ReadLine());

            double mitj = (pra * 0.3) + (exa * 0.7);

            double resFinal = Math.Round(mitj);

            // if (mitj - Math.Truncate(mitj) < 0.7)
            // {
            //     resFinal = Math.Floor(mitj);
            // }
            // else
            // {
            //     resFinal = Math.Ceiling(mitj);
            // }
            Console.WriteLine($"Nota de pràctiques: {pra}");
            Console.WriteLine($"Nota de l'examen: {exa}");
            Console.WriteLine($"La nota final és {mitj} o sigui un {resFinal}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
