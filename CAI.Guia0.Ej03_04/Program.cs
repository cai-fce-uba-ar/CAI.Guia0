using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ingreso))
            {
                Console.WriteLine("Ha ingresado una cadena vacía, o sólo espacios en blanco.");
            }
            else
            {
                Console.WriteLine("NO ha ingresado una cadena vacía ni espacios en blanco.");
            }

            Console.ReadKey();
        }
    }
}
