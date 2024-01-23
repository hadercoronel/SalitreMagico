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
    public partial class RegistrarPasaporte : Form
    {
        string response;
        public RegistrarPasaporte()
        {
            InitializeComponent();
        }
        public RegistrarPasaporte(Empleado empleado)
        {
            InitializeComponent();
            if (empleado != null)
            {
                txtIdVendedor.Text = empleado.Id == 0? "" : empleado.Id.ToString();
            }
        }
        Pasaporte pasaporte = new Pasaporte();
        PasaporteAdmin pasaporteAdmin = new PasaporteAdmin();
        ClienteAdmin clienteAdmin = new ClienteAdmin();
        private void Pasaporte_Load(object sender, EventArgs e)
        {
            cboxTipoPasaporte.DataSource = Enum.GetValues(typeof(TipoPasaporte));
            cboxEstacion.DataSource = Enum.GetValues(typeof(Estacion));
            cboxEstado.DataSource = Enum.GetValues(typeof(Estado));
        }

        private void cboxTipoPasaporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipoPasaporte.SelectedItem != null)
            {
                string categoriaSeleccionada = cboxTipoPasaporte.SelectedItem.ToString();

                // se asigna valor a txtprecio y txtdescripcion segun el pasaporte
                switch (categoriaSeleccionada)
                {
                    case "KID":
                        txtPrecioRegular.Text = "30.000";
                        txtDescripcion.Text = "Diseñado para los más chiquitos de nuestras familias, " +
                            "incluye una amplia variedad de atracciones infantiles y familiares."+ 
                            Environment.NewLine +
                            Environment.NewLine + 
                            "No incluye Juegos de Destreza.";
                        break;
                    case "NITRO":
                        txtPrecioRegular.Text = "60.000";
                        txtDescripcion.Text = "Incluye todas las atracciones del parque excepto Karts, " +
                            "Chocones,Castillo del Terror y Juegos de Destreza.";
                        break;
                    case "NITROPLUS":
                        txtPrecioRegular.Text = "90.000";
                        txtDescripcion.Text = "Vive la máxima experiencia de Salitre Mágico con todas " +
                            "las atracciones del parque incluyendo el ingreso por 1 vez al Castillo del " +
                            "Terror, Carros Chocones y Pista de Karts."+
                            Environment.NewLine +
                            Environment.NewLine +
                            "No incluye Juegos de Destreza.";
                        break;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cboxTipoPasaporte.SelectedIndex != -1 && cboxEstacion.SelectedIndex != -1 && cboxEstado.SelectedIndex != -1
               && txtIdCliente.Text != "" && txtIdVendedor.Text != "" && txtDescripcion.Text != "")
            {
                mapearPasaporte();
                if (txtIdCliente.Text != "")
                {
                    pasaporte.Cliente = new Cliente(txtIdCliente.Text);
                    pasaporte.Cliente = clienteAdmin.ConsultarCliente(pasaporte.Cliente.Identificacion);
                    if (pasaporte.Cliente == null)
                    {
                        MessageBox.Show("Responsable no existe.");
                    }
                    else
                    {
                            response = pasaporteAdmin.Guardar(pasaporte);
                            MessageBox.Show(response);
                            txtIdCliente.Clear();
                    }
                }
                else
                {

                    MessageBox.Show("Hay campos vacios!!!");
                }
            }
        }
        /// <summary>
        /// se asignan los valores de los text al cliente.
        /// </summary>
        private void mapearPasaporte()
        {
            pasaporte.TipoPasaporte = (TipoPasaporte)Enum.Parse(typeof(TipoPasaporte), cboxTipoPasaporte.Text);
            pasaporte.NumeroEstacion = (Estacion)Enum.Parse(typeof(Estacion), cboxEstacion.Text);
            pasaporte.Fecha = cboxFecha.Value;
            pasaporte.Estado = (Estado)Enum.Parse(typeof(Estado), cboxEstado.Text);
            pasaporte.Descripcion= txtDescripcion.Text;
            pasaporte.Precio = decimal.Parse(txtPrecioRegular.Text);
            pasaporte.Cliente = new Cliente(txtIdCliente.Text);
            pasaporte.Empleado = new Empleado(int.Parse(txtIdVendedor.Text));
        }
    }
}
