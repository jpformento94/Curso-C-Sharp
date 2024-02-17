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
            //Telefono 1
            Telefono telefono1 = new Telefono("Samsung","S24");
            Console.WriteLine("La marca es " + telefono1.marca);
            Console.WriteLine("El modelo es " + telefono1.modelo);
            telefono1.numeroTelefonico = "1234";
            Console.WriteLine("El numero es " + telefono1.numeroTelefonico);
            telefono1.codigoOperador = 1;
            Console.WriteLine("El codigo de operador es " + telefono1.codigoOperador);
            Console.WriteLine(telefono1.llamar());
            Console.WriteLine("");

            //Telefono 2
            Telefono telefono2 = new Telefono("Apple", "16");
            Console.WriteLine("La marca es " + telefono2.marca);
            Console.WriteLine("El modelo es " + telefono2.modelo);
            telefono2.numeroTelefonico = "4321";
            Console.WriteLine("El numero es " + telefono2.numeroTelefonico);
            telefono2.codigoOperador = 3;
            Console.WriteLine("El codigo de operador es " + telefono2.codigoOperador);
            Console.WriteLine(telefono2.llamar("Juan"));
        }
    }
}
