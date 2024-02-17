using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel = new Telefono();
            Console.WriteLine("La marca es " + tel.marca);
            Console.WriteLine("El modelo es " + tel.modelo);
            Console.WriteLine("El numero es " + tel.numeroTelefonico);
            Console.WriteLine("El codigo de operador es " + tel.codigoOperador);
            tel.numeroTelefonico = "1234";
            Console.WriteLine("El numero es " + tel.numeroTelefonico);
            tel.codigoOperador = 123;
            Console.WriteLine("El codigo de operador es " + tel.codigoOperador);
            tel.codigoOperador = 1;
            Console.WriteLine("El codigo de operador es " + tel.codigoOperador);
            Console.ReadLine();
        }
    }
}
