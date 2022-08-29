using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Aerolinea
    {
        List<Avion> flota = new List<Avion>();

        public void Add(Avion a)
        {
            flota.Add(a);
        }

        public List<Avion> GetAll()
        {
            return flota.OrderBy(a => a.Año).ToList() ;
        }

        public List<Avion> GetByEstado(Estado e)
        {
            List<Avion> filtro = new List<Avion>();
            foreach (Avion avion in flota)
            {
                if (avion.Estado == e)
                {
                    filtro.Add(avion);
                }
            }
            return filtro;
        }
    }
}
