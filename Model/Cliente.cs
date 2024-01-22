using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private TipoIdentificacion tipoIdentificacion;
        private string identificacion;
        private string telefono;
        private string correoElectronico;
        private float estatura;
        private int edad;
        private Cliente responsable;
        private int numeroIngreso;

        public Cliente(int id, string nombre, TipoIdentificacion tipoIdentificacion, string identificacion, 
                        string telefono, string correoElectronico, float estatura, 
                        int edad, Cliente responsable, int numeroIngreso)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipoIdentificacion = tipoIdentificacion;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.estatura = estatura;
            this.edad = edad;
            this.responsable = responsable;
            this.numeroIngreso = numeroIngreso;
        }

        public Cliente()
        { 
        
        }

        public Cliente(string identificacion)
        {
            this.identificacion = identificacion;
        }

        public Cliente(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public TipoIdentificacion TipoIdentificacion { get => tipoIdentificacion; set => tipoIdentificacion = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public int Edad { get => edad; set => edad = value; }
        public Cliente Responsable { get => responsable; set => responsable = value; }
        public int NumeroIngreso { get => numeroIngreso; set => numeroIngreso = value; }
    }
}
