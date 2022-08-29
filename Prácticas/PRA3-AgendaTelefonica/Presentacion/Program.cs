using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Datos;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda();

            Persona c1 = new Persona("Bruno", "Diaz", new DateTime(1970, 9, 24), "+5699887766", Clasificacion.Default);
            Persona c2 = new Persona("Antonio", "Stark", new DateTime(1975, 8, 14), "+5688776655", Clasificacion.Amigos);
            Persona c3 = new Persona("Pedro", "Parker", new DateTime(2002, 10, 04), "+56922335544", Clasificacion.Amigos);

            miAgenda.Add(c1);
            miAgenda.Add(c2);
            miAgenda.Add(c3);

            Console.WriteLine("AGENDA");
            foreach (Persona persona in miAgenda.GetAll())
            {
                Console.WriteLine("{0} {1} - {2} años - {3}", persona, persona.Telefono, persona.Edad, persona.Clasificacion);
            }


            Console.WriteLine("\n\nAGENDA AMIGOS");
            foreach (Persona persona in miAgenda.GetPersonas(Clasificacion.Amigos))
            {
                Console.WriteLine("{0} {1} - {2} años", persona, persona.Telefono, persona.Edad);
            }

            Console.ReadKey();
        }
    }
}
