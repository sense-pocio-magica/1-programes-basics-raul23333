namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 



class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Quina hora es? (1 a 12): ");
            int horaAct = Convert.ToInt32(Console.ReadLine());

            while (horaAct <= 0 || horaAct > 12)
            {
                Console.Write("Aquesta hora no és correcta, introdueix una altra si us plau: ");
                horaAct = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Quantes hores vols afegir? ");
            int horesInc = Convert.ToInt32(Console.ReadLine());

            int horaFutura = (horaAct + horesInc) % 12;
            if (horaFutura == 0) horaFutura = 12;

            Console.WriteLine($"D'aqui {horesInc} hores serán les {horaFutura}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}




/*Com que no sabia si demanaves que només et preguntes l'hora i ell automàticament et digues 
quant falta per tal hora o et preguntes també les hores a incrementar, he fet les dues jejeje*/

// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             Console.Write("Quina hora es? ");
//             int horaact = Convert.ToInt16(Console.ReadLine());
//             int horesinc;
//             while (true)
//             {
//                 if (horaact <= 0 || horaact > 12)
//                 {
//                     Console.Write("Aquesta hora no es correcte, introduiex un altre si us plau: ");
//                     horaact = Convert.ToInt16(Console.ReadLine());
//                 }
//                 else
//                 {
//                     break;
//                 }
//             }
//             if (horaact <= 5)
//             {
//                 int hora = 6;
//                 horesinc = hora - horaact;
//                 Console.WriteLine($"D'aquí {horesinc} hores seran les {hora}");
//             }
//             else
//             {
//                 int hora = 12;
//                 horesinc = hora - horaact;
//                 Console.WriteLine($"D'aquí {horesinc} hores seran les {hora}");
//             }
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e.Message);
//         }
//     }
// }