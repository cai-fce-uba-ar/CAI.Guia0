using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            string ingreso = Console.ReadLine();
            int numero1 = int.Parse(ingreso);

            Console.WriteLine("Ingrese otro número entero:");
            ingreso = Console.ReadLine();
            int numero2 = int.Parse(ingreso);

            //a - la suma:
            int suma = numero1 + numero2;
            Console.WriteLine("La suma es:");
            Console.WriteLine(suma);

            //b - la resta:
            int resta = numero1 - numero2;
            Console.WriteLine("La resta es:");
            Console.WriteLine(resta);

            //c - el producto:
            int producto = numero1 * numero2;
            Console.WriteLine("El producto es:");
            Console.WriteLine(producto);

            //d - la potencia
            int potencia = (int)Math.Pow(numero1, numero2);
            Console.WriteLine("La potencia es:");
            Console.WriteLine(potencia);

            //e - el módulo
            int modulo = numero1 % numero2;
            Console.WriteLine("El módulo (resto) de a/b es:");
            Console.WriteLine(modulo);

            Console.ReadKey();
        }
    }
}
