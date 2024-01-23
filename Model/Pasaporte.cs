using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pasaporte
    {
        private int id;
        private TipoPasaporte tipoPasaporte;
        private DateTime fecha;
        private string descripcion;
        private decimal precio;
        private Cliente cliente;
        private Estacion numeroEstacion;
        private Estado estado;
        private Empleado empleado;

        public Pasaporte(int id, TipoPasaporte tipoPasaporte, DateTime fecha, string descripcion, 
            decimal precio, Cliente cliente, Estacion numeroEstacion, Estado estado, Empleado empleado)
        {
            this.id = id;
            this.tipoPasaporte = tipoPasaporte;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cliente = cliente;
            this.numeroEstacion = numeroEstacion;
            this.estado = estado;
            this.empleado = empleado;
        }
        public Pasaporte() { }

        public int Id { get => id; set => id = value; }
        public TipoPasaporte TipoPasaporte { get => tipoPasaporte; set => tipoPasaporte = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Estacion NumeroEstacion { get => numeroEstacion; set => numeroEstacion = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
    }
}
