using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        private string nombre;
        private int tipo_identificacion;
        private string identificacion;
        private string telefono;
        private string correoElectronico;
        private float estatura;
        private int edad;
        private int responsable;
        private int numeroIngreso;

        public Cliente(string nombre, int tipo_identificacion, string identificacion, 
                        string telefono, string correoElectronico, float estatura, 
                        int edad, int responsable, int numeroIngreso)
        {
            this.nombre = nombre;
            this.tipo_identificacion = tipo_identificacion;
            this.identificacion = identificacion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.estatura = estatura;
            this.edad = edad;
            this.responsable = responsable;
            this.numeroIngreso = numeroIngreso;
        }

        Cliente()
        { 
        
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo_identificacion { get => tipo_identificacion; set => tipo_identificacion = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Responsable { get => responsable; set => responsable = value; }
        public int NumeroIngreso { get => numeroIngreso; set => numeroIngreso = value; }
    }
}
