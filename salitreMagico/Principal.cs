using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salitreMagico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
         Empleado empleado = null;
        public Principal(Usuario usuario, Empleado empleado)
        {
            InitializeComponent();
            if (usuario != null) 
            {
                lblNombreUsuario.Text = usuario.Nombre;
            }
            if (empleado != null)
            {
                this.empleado = empleado;
            }
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();

            // Se hace un llamado al form Registrar cliente
            registrarCliente.Show();
        }

        private void registrarPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistrarPasaporte registrarPasaporte = new RegistrarPasaporte(empleado);

            // Se hace un llamado al form Registrar Pasaporte
            registrarPasaporte.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ingresarParqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoParque ingresoParque = new IngresoParque();
            ingresoParque.Show();
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaCliente tablaCliente = new TablaCliente();
            tablaCliente.Show();
        }
    }
}
