using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Agenda
    {
       private List<Persona> contactos = new List<Persona>();

        public void Add(Persona p)
        {
            contactos.Add(p);
        }

        public List<Persona> GetAll()
        {
            return contactos;
        }

        public List<Persona>GetPersonas(Clasificacion filtro)
        {
            return contactos.FindAll(p => p.Clasificacion == filtro);
        }
    }
}
