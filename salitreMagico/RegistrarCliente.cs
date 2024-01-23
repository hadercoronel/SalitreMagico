using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;

namespace salitreMagico
{
    public partial class RegistrarCliente : Form
    {
        string response;
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        Cliente cliente = new Cliente();
        ClienteAdmin clienteAdmin = new ClienteAdmin();

        private void Form1_Load(object sender, EventArgs e)
        {
            //llenar combobox 
            CboxTipoIdentificacion.DataSource = Enum.GetValues(typeof(TipoIdentificacion));
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && CboxTipoIdentificacion.SelectedIndex != -1 && txtIdentificacion.Text != ""
                && txtEstatura.Text != "" && txtTelefono.Text != "" && txtEdad.Text != "" && txtCorreoElectronico.Text != "")
            {
                mapearCliente();
                if (cliente.Edad < 18)
                {
                    if (txtResponsable.Text != "")
                    {
                        cliente.Responsable = new Cliente(txtResponsable.Text);
                        cliente.Responsable = clienteAdmin.ConsultarCliente(cliente.Responsable.Identificacion);
                        if (cliente.Responsable == null)
                        {
                            MessageBox.Show("Responsable no existe.");
                        } else
                        {
                            if (cliente.Responsable.Edad > 17)
                            {
                                response = clienteAdmin.Guardar(cliente);
                                MessageBox.Show(response);
                                limpiarText(this);
                            }
                            else { MessageBox.Show("Responsable debe ser mayor de edad."); }
                        }
                    }else
                    {
                        MessageBox.Show("Debe ingresar un responsable registrado");
                    }
                } else
                {
                    cliente.Responsable = null;
                    response = clienteAdmin.Guardar(cliente);
                    MessageBox.Show(response);
                    limpiarText(this);
                }       
                
            }
            else 
            {

                MessageBox.Show("Hay campos vacios!!!");
            }
        }

        /// <summary>
        /// se asignan los valores de los text al cliente.
        /// </summary>
        private void mapearCliente ()
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Estatura = float.Parse(txtEstatura.Text);
            cliente.Edad = int.Parse(txtEdad.Text);
            cliente.TipoIdentificacion = (TipoIdentificacion)Enum.Parse(typeof(TipoIdentificacion), CboxTipoIdentificacion.Text);
            cliente.CorreoElectronico = txtCorreoElectronico.Text;
            cliente.Identificacion = txtIdentificacion.Text;
            cliente.Telefono = txtTelefono.Text;

        }
        /// <summary>
        /// limpiar los campos de texto.
        /// </summary>
        /// <param name="control"></param>
        private void limpiarText(Control control) {
            foreach (var txt in control.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if(txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y una coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // Permitir solo una coma
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite letras
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreoElectronico_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreoElectronico.Text.Trim();

            // Solo permite correos que contengan una estructura "ejemplo@example.com"
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regexCorreo = new Regex(patronCorreo);

            if (!regexCorreo.IsMatch(correo))
            {
                MessageBox.Show("Dirección de correo electrónico no válida.");
                e.Cancel = true; 
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
