using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero:");
            string ingreso = Console.ReadLine();

            bool esCorrecto = int.TryParse(ingreso, out int resultado);
            if (!esCorrecto)
            {
                Console.WriteLine("No ha ingresado un número entero válido.");
            }
            else
            {
                Console.WriteLine("Ingreso válido.");
            }

            Console.ReadKey();
        }
    }
}
