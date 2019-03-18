using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Su nombre completo es " + nombre + " " + apellido);

            //otras alternativas de sintaxis:

            //interpolacion de cadenas (string interpolation)
            Console.WriteLine($"Su nombre completo es {nombre} {apellido}");

            //cadena de formato (format string)
            Console.WriteLine("Su nombre completo es {0} {1}", nombre, apellido);

            //método concat de la clase string
            string nombreCompleto = string.Concat(nombre, " ", apellido);
            Console.Write("Su nombre completo es "); //noten que se usa Write (sin retorno de linea al final) en vez de WriteLine
            Console.WriteLine(nombreCompleto);

            Console.ReadKey();
        }
    }
}
