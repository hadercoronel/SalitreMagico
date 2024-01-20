using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Atraccion
    {
        private string nombreMaquina;
        private int numeroOcupante;
        private float estaturaMinima;
        private int estado;
        private string descripcion;
        private int clasificacion;
        private int tipoEntrada;
        private float estaturaMaxima;

        public Atraccion(string nombreMaquina, int numeroOcupante, float estaturaMinima, int estado, 
                        string descripcion, int clasificacion, int tipoEntrada, float estaturaMaxima)
        {
            this.nombreMaquina = nombreMaquina;
            this.numeroOcupante = numeroOcupante;
            this.estaturaMinima = estaturaMinima;
            this.estado = estado;
            this.descripcion = descripcion;
            this.clasificacion = clasificacion;
            this.tipoEntrada = tipoEntrada;
            this.estaturaMaxima = estaturaMaxima;
        }

        public string NombreMaquina { get => nombreMaquina; set => nombreMaquina = value; }
        public int NumeroOcupante { get => numeroOcupante; set => numeroOcupante = value; }
        public float EstaturaMinima { get => estaturaMinima; set => estaturaMinima = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Clasificacion { get => clasificacion; set => clasificacion = value; }
        public int TipoEntrada { get => tipoEntrada; set => tipoEntrada = value; }
        public float EstaturaMaxima { get => estaturaMaxima; set => estaturaMaxima = value; }
    }
}
