using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Persona p = new Persona();
            Persona p1 = new Persona(new DateTime(1980, 9, 24));
            Agenda miAgenda = new Agenda();

            p.Nombre = "Bruno";
            p.Apellido = "Diaz";

            p1.Nombre = "Antonio";
            p1.Apellido = "Stark";

            miAgenda.Add(p);
            miAgenda.Add(p1); 
            

            Console.WriteLine("Hola " +p.Nombre + " " + p.Apellido);

            foreach (Persona persona in miAgenda.GetAll())
            {
                Console.WriteLine("{0} tiene {1} años", persona, persona.Edad);
            }

            Console.ReadKey();
        }
    }
}
