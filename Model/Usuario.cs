using Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string password;
        private string confirmarPassword;
        private string estado;

        private List<Rol> roles;

        public Usuario() { }

        public Usuario(int id, string nombre, string password, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            this.estado = estado;
        }

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmarPassword { get => confirmarPassword; set => confirmarPassword = value; }

        public string Estado { get => estado; set => estado = value; }
    }
}
