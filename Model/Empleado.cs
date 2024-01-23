using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empleado
    {
        private int id;
        private int tipoIdentificacion;
        private string nombre;
        private string identificacion;
        private string telefono;
        private string correoElectronico;
        private int edad;

        public Empleado(int id, int tipoIdentificacion, string nombre, string identificacion, string telefono, string correoElectronico, int edad)
        {
            this.id = id;
            this.tipoIdentificacion = tipoIdentificacion;
            this.nombre = nombre;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.edad = edad;
        }
        public Empleado() { }
        public Empleado(string identificacion)
        {
            this.identificacion = identificacion;
        }
        public int Id { get => id; set => id = value; }
        public int TipoIdentificacion { get => tipoIdentificacion; set => tipoIdentificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
