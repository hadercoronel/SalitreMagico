using Modelos;
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
using Modelos.Enums;

namespace salitreMagico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private UsuarioAdmin usuarioAdmin = new UsuarioAdmin();
        Usuario usuario;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuario(txtUsuario.Text, txtContraseña.Text);

                Usuario usuarioAux = usuarioAdmin.verificarPassword(usuario);
                if (usuarioAux == null)
                {
                    MessageBox.Show("Usuario no existe.");
                }
                else
                {
                    List<Rol> rols = usuarioAdmin.ConsultarRoles(usuario.Nombre);
                    if (rols != null && rols.Count > 0)
                    {
                        Empleado empleado = usuarioAdmin.verificarEmpleado(usuario);
                        
                        switch (rols[0])
                        {
                            case Rol.ADMINISTRATIVO:
                                Principal principal = new Principal(usuario, empleado);
                                this.Hide();
                                principal.ShowDialog();
                                this.Close(); 
                                break;
                            case Rol.LOGISTICA:
                                Principal principalLogistica = new Principal();
                                this.Hide();
                                principalLogistica.ShowDialog();
                                this.Close();
                                break;
                            default:
                                MessageBox.Show("Rol no especificado.");
                                break;    
                        }
                    }else
                    {
                        MessageBox.Show("Algo ocurrio.");
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error de sistema." + ex.StackTrace);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
