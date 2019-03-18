using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena:");
            string ingreso = Console.ReadLine();

            Console.WriteLine("Si eliminamos los espacios en blanco ...");
            Console.WriteLine(ingreso.Replace(" ", string.Empty));

            Console.ReadKey();
        }
    }
}
