namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        string nom_usu = "raul23";
        string domini = "cendrassos.net";
        Console.WriteLine($"{nom_usu}@{domini}");
    }
}
