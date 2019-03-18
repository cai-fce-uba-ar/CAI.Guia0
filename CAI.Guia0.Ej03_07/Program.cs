using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string cadena1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra cadena:");
            string cadena2 = Console.ReadLine();

            if (cadena1.Contains(cadena2))
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
