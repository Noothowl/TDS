using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Agenda
    {
        List<Persona> personas = new List<Persona>();

        public void Add(Persona p)
        {
            personas.Add(p);
        }

        public List<Persona> GetAll()
        {
            return personas;
        }
    }
}
