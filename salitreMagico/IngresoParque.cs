using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;

namespace salitreMagico
{
    public partial class IngresoParque : Form
    {

        ClienteAdmin clienteAdmin = new ClienteAdmin();
        public IngresoParque()
        {
            InitializeComponent();
        }

        private void IngresoParque_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentificacion.Text != "")
                {


                    Cliente existe = clienteAdmin.ConsultarCliente(txtIdentificacion.Text);
                    if (existe != null)
                    {
                        string msm = clienteAdmin.UpdateCliente(existe);
                        MessageBox.Show("Bienvenido su ingreso fue exitoso.");
                        this.Close();
                    } else
                    {
                        RegistrarCliente frmRegistrar = new RegistrarCliente();
                        frmRegistrar.ShowDialog();
                    }
                } else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            { 
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
