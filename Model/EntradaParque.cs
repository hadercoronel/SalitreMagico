using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class EntradaParque
    {
        private float valorEntrada;
        private DateTime fechaEntrada;
        private int tipoPersona;

        public EntradaParque(float valorEntrada, DateTime fechaEntrada, int tipoPersona)
        {
            this.valorEntrada = valorEntrada;
            this.fechaEntrada = fechaEntrada;
            this.tipoPersona = tipoPersona;
        }

        public float ValorEntrada { get => valorEntrada; set => valorEntrada = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public int TipoPersona { get => tipoPersona; set => tipoPersona = value; }
    }
}
