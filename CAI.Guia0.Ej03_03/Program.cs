using System;

namespace CAI.Guia0.Ej03_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            if (string.IsNullOrEmpty(ingreso))
            {
                Console.WriteLine("Ha ingresado una cadena vacía.");
            }
            else
            {
                Console.WriteLine("NO ha ingresado una cadena vacía");
            }

            Console.ReadKey();
        }
    }
}
