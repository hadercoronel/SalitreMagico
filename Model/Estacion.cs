using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Estacion
    {
        private int numeroEstacion;
        private int estado;

        public Estacion(int numeroEstacion, int estado)
        {
            this.numeroEstacion = numeroEstacion;
            this.estado = estado;
        }

        public int NumeroEstacion { get => numeroEstacion; set => numeroEstacion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
