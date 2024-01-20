using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class TipoPasaporte
    {
        private String nombre;
        private String descripcion;
        private float precioRegular;

        public TipoPasaporte(string nombre, string descripcion, float precioRegular)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioRegular = precioRegular;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float PrecioRegular { get => precioRegular; set => precioRegular = value; }
    }
}
