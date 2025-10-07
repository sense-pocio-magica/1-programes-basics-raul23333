namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Entra la data sense formatar: ");
            string data_no_format = Console.ReadLine();
            while (true)
            {
                if (data_no_format.Length != 8)
                {
                    Console.Write("Entra la data sense formatar (DDMMAAAA): ");
                    data_no_format = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            var dia = data_no_format.Substring(0, 2);
            var mes = data_no_format.Substring(2, 2);
            var any = data_no_format.Substring(4);

            Console.WriteLine($"La data és {dia}/{mes}/{any}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
