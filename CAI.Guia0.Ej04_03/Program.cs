using System;

namespace CAI.Guia0.Ej04_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero positivo:");
            string ingreso = Console.ReadLine();

            bool esCorrecto = int.TryParse(ingreso, out int resultado);
            if (!esCorrecto || resultado < 0)
            {
                Console.WriteLine("No ha ingresado un número entero positivo válido.");
            }
            else
            {
                Console.WriteLine("Ingreso válido.");
            }

            Console.ReadKey();
        }
    }
}
