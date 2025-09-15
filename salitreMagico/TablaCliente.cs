using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
    
namespace salitreMagico
{
    public partial class TablaCliente : Form
    {
        ClienteAdmin clienteAdmin = new ClienteAdmin();
        public TablaCliente()
        {
            InitializeComponent();
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            var lista = clienteAdmin.Consultar();
            dataGridCliente.DataSource = lista;

        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
