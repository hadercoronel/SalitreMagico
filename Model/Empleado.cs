using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Empleado
    {
        private int tipoEmpleado;
        private string nombre;
        private string identificacion;
        private string telefono;
        private string correoElectronico;
        private int edad;

        public Empleado(int tipoEmpleado, string nombre, string identificacion, 
                        string telefono, string correoElectronico, int edad)
        {
            this.tipoEmpleado = tipoEmpleado;
            this.nombre = nombre;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.edad = edad;
        }

        public int TipoEmpleado { get => tipoEmpleado; set => tipoEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
