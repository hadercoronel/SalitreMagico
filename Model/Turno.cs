using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Turno
    {
        private String jornada;
        private String dia;
        private int numeroHoras;
        private String horaInicio;

        public Turno(string jornada, string dia, int numeroHoras, string horaInicio)
        {
            this.jornada = jornada;
            this.dia = dia;
            this.numeroHoras = numeroHoras;
            this.horaInicio = horaInicio;
        }

        public string Jornada { get => jornada; set => jornada = value; }
        public string Dia { get => dia; set => dia = value; }
        public int NumeroHoras { get => numeroHoras; set => numeroHoras = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
    }
}
