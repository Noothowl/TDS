using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        //CAMPOS
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;


        //CONSTRUCTOR
        public Persona()
        {
            // FechaNacimiento = new DateTime(2022, 8, 26);
            FechaNacimiento = DateTime.Today;
        }

        public Persona(DateTime fechaNacimiento)
        {
            FechaNacimiento = fechaNacimiento;
        }



        //PROPIEDADES
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public byte Edad
        {
            get
            {
                int añoActual = DateTime.Today.Year;
                int añoNac = FechaNacimiento.Year;

                return (byte)(añoActual - añoNac);
            }
        }

        //METODOS
        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
