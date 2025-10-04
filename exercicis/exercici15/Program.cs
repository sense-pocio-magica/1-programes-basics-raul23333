using System;

namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        string nom = "raul";
        string cognom = "osuna";

        nom = char.ToUpper(nom[0]).ToString() + nom.Substring(1);
        cognom = char.ToUpper(cognom[0]).ToString() + cognom.Substring(1);

        Console.WriteLine($"Hola {nom} {cognom}");
    }
}