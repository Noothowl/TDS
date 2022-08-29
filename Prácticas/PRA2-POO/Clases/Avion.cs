using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Avion
    {
        private string _codigo;
        private Estado _estado;
        private int _año;

        public Avion()
        {
            _estado = Estado.Disponible;
        }

        public Avion(string codigo, Estado estado, int año)
        {
            Codigo = codigo;
            Estado = estado;
            Año = año;
        }

        public string Codigo { get => _codigo; set => _codigo = value; }
        public Estado Estado { get => _estado; set => _estado = value; }
        public int Año { get => _año; set => _año = value; }


    }

    public enum Estado
    {
        Disponible,
        Reparando,
        Retirado
    }
}
