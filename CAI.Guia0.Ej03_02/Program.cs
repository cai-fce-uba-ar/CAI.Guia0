using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Su nombre es {nombre} y su apellido {apellido}");

            Console.ReadKey();
        }
    }
}
