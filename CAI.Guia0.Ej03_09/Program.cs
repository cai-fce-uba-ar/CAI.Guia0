using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            if(ingreso.Length < 5)
            {
                Console.WriteLine("No contiene al menos 5 caracteres.");
            }
            else
            {
                Console.Write(ingreso.Substring(3, ingreso.Length - 5));
            }

            Console.ReadKey();
        }
    }
}
