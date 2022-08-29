using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public Clasificacion Clasificacion { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, Clasificacion clasificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Clasificacion = clasificacion;
        }

        public int Edad
        {
            get {
                return DateTime.Today.Year - FechaNacimiento.Year;
            }
          
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}
