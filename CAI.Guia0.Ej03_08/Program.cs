using System;

namespace CAI.Guia0.Ej03_08
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ejercicio 6:

            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            if (ingreso.IndexOf("a", StringComparison.InvariantCultureIgnoreCase) != -1)
            {
                Console.WriteLine("La cadena contiene una 'a'");
            }
            else
            {
                Console.WriteLine("La cadena NO contiene una 'a'");
            }

            //ejercicio 7

            Console.WriteLine("Ingrese una cadena:");
            string cadena1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra cadena:");
            string cadena2 = Console.ReadLine();

            if (cadena1.IndexOf(cadena2, StringComparison.InvariantCultureIgnoreCase) != -1)
            {
                Console.WriteLine($"'{cadena1}' CONTIENE '{cadena2}'");
            }
            else
            {
                Console.WriteLine($"'{cadena1}' NO CONTIENE '{cadena2}'");
            }

            Console.ReadKey();
        }
    }
}
