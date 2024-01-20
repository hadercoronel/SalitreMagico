using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Pasaporte
    {
        private int numeroTicket;
        private DateTime fecha;
        private DateTime horaEntrada;
        private int idEstacion;
        private int idCliente;
        private int idTipoPasaporte;
        private float descuento;
        private float totalPagar;

        public Pasaporte(int numeroTicket, DateTime fecha, DateTime horaEntrada, int idEstacion, 
                         int idCliente, int idTipoPasaporte, float descuento, float totalPagar)
        {
            this.numeroTicket = numeroTicket;
            this.fecha = fecha;
            this.horaEntrada = horaEntrada;
            this.idEstacion = idEstacion;
            this.idCliente = idCliente;
            this.idTipoPasaporte = idTipoPasaporte;
            this.descuento = descuento;
            this.totalPagar = totalPagar;
        }

        public int NumeroTicket { get => numeroTicket; set => numeroTicket = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int IdEstacion { get => idEstacion; set => idEstacion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdTipoPasaporte { get => idTipoPasaporte; set => idTipoPasaporte = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
    }
}
