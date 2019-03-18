using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI.Guia0.Ej02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            string ingreso = Console.ReadLine();
            decimal numero1 = decimal.Parse(ingreso);

            Console.WriteLine("Ingrese otro número:");
            ingreso = Console.ReadLine();
            decimal numero2 = decimal.Parse(ingreso);

            //a - la suma:
            decimal suma = numero1 + numero2;
            Console.WriteLine("La suma es:");
            Console.WriteLine(suma);

            //b - la resta:
            decimal resta = numero1 - numero2;
            Console.WriteLine("La resta es:");
            Console.WriteLine(resta);

            //c - el producto:
            decimal producto = numero1 * numero2;
            Console.WriteLine("El producto es:");
            Console.WriteLine(producto);

            //d - la potencia
            decimal potencia = (decimal)Math.Pow((double)numero1, (double)numero2);
            Console.WriteLine("La potencia es:");
            Console.WriteLine(potencia);

            //e - el módulo
            decimal modulo = numero1 % numero2;
            Console.WriteLine("El módulo (resto) de a/b es:");
            Console.WriteLine(modulo);

            Console.ReadKey();
        }
    }
}
