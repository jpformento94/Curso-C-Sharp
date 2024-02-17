using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Telefono
    {

        public Telefono(String marca, String modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

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

        public String llamar()
        {
            return "Realizando llamada...";
        }

        public String llamar(String contacto)
        {
            return $"Llamando a {contacto}";
        }
    }
}