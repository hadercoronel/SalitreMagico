using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class HorarioLaboral
    {
        private DateTime fecha;
        private int idTurno;
        private int idEmpleado;

        public HorarioLaboral(DateTime fecha, int idTurno, int idEmpleado)
        {
            this.fecha = fecha;
            this.idTurno = idTurno;
            this.idEmpleado = idEmpleado;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
