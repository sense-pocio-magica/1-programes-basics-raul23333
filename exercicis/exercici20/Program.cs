using System;
using System.Linq;

namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introdueix un número de 3 xifres: ");
                string num = Console.ReadLine();

                while (true)
                {

                    if (num.Length == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Introdueix un altre número amb 3 xifres: ");
                        num = Console.ReadLine();
                    }
                }
                string resultat = new string(num.Reverse().ToArray()); 
                Console.WriteLine($"El número invertit és: {resultat}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }