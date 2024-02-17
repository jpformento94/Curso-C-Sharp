using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Telefono
    {

        public String modelo { get; }
        public String marca { get; }

        public String numeroTelefonico { get; set; }

        private int _codigoOperador;

        public int codigoOperador
        {
            get { return _codigoOperador; }
            set
            {
                if ((value == 1) || (value == 2) || (value == 3))
                {
                    _codigoOperador = value;
                }
                else
                {
                    _codigoOperador = 0;
                }

            }
        }



        /*
           
        Agregar Constructor que reciba Modelo y Marca.
            
        Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
            
        Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
            
        Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
            
        Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.*/




    }
}
