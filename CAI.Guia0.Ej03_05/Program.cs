using System;

namespace CAI.Guia0.Ej03_05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            Console.WriteLine($"La longitud del texto ingresado es {ingreso.Length}");

            Console.ReadKey();
        }
    }
}
