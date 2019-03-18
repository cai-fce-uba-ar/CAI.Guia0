using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            if(ingreso.IndexOf('a') != -1)
            {
                Console.WriteLine("La cadena contiene una 'a'");
            }
            else
            {
                Console.WriteLine("La cadena NO contiene una 'a'");
            }

            Console.ReadKey();
        }
    }
}
