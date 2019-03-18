using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero decimal:");
            string ingreso = Console.ReadLine();

            bool esCorrecto = decimal.TryParse(ingreso, out decimal resultado);
            if (!esCorrecto)
            {
                Console.WriteLine("No ha ingresado un número decimal válido.");
            }
            else
            {
                Console.WriteLine("Ingreso válido.");
            }

            Console.ReadKey();
        }
    }
}
