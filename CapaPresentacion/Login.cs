using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        E_Empleado Empleado = new E_Empleado();
        public Login()
        {
            InitializeComponent();
        }
        //metodo para confirmar
        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //metodo para mostrar mensaje error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ferreteria de Emanuel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            //DataTable Datos = N_Empleado.IniciarSesion(txtUsuario.Text,txtPassword.Text);
            ////verificar si existe el usuario
            //if (Datos.Rows.Count == 0) 
            //{
            //    MensajeError("Acceso Denegado");
            //}
            //else if (txtUsuario.Text != "")
            //{
            //    if (txtPassword.Text != "")
            //    {
            //        FrmMenu Menu = new FrmMenu();
            //        Menu.IdEmpleado = Datos.Rows[0][0].ToString();
            //        Menu.Nombre = Datos.Rows[0][1].ToString();
            //        Menu.Apellido = Datos.Rows[0][2].ToString();
            //        Menu.Acceso = Datos.Rows[0][3].ToString();

            //        //PROBANDO PASAR DATOS A ENTIDAD DATOS DE EMPLEADO
            //        //E_Datos_Login.Id_empleado = Convert.ToInt32(Datos.Rows[0][0].ToString());
            //        //E_Datos_Login.Nombre = Datos.Rows[0][1].ToString();
            //        //E_Datos_Login.Apellido = Datos.Rows[0][2].ToString();
            //        //E_Datos_Login.Acceso = Datos.Rows[0][3].ToString();

            //        this.Hide();
            //        Menu.Show();
            //    }
            //    else
            //    {
            //        MensajeError("Ingrese Contraseña");
            //        txtPassword.Text = string.Empty;
            //        txtPassword.Focus();
            //    }
            //}
            //else
            //{
            //    MensajeError("Datos de usuario incorrectos");
            //    txtPassword.Text = string.Empty;
            //    txtPassword.Focus();
            //}

            if (txtUsuario.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    N_Empleado Iniciar = new N_Empleado();
                    var Validar = Iniciar.IniciarSesion(txtUsuario.Text, txtPassword.Text);

                    if (Validar == true)
                    {
                        if (E_Datos_Login.Acceso == E_Acceso.Administrador)
                        {
                            Hide();
                            FrmMenu Menu = new FrmMenu
                            {
                                Acceso = "ADMINISTRADOR"
                            };
                            Menu.Show();
                        }
                        if (E_Datos_Login.Acceso == E_Acceso.Vendedor)
                        {
                            Hide();
                            FrmMenu Menu = new FrmMenu
                            {
                                Acceso = "VENDEDOR"
                            };
                            Menu.Show();
                        }
                        if (E_Datos_Login.Acceso == E_Acceso.Bodeguero)
                        {
                            Hide();
                            FrmMenu Menu = new FrmMenu
                            {
                                Acceso = "BODEGUERO"
                            };
                            Menu.Show();
                        }
                    }
                    else
                    {
                        MensajeError("Datos de usuario incorrectos, Intente de nuevo");
                        txtPassword.Text = string.Empty;
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MensajeError("Ingrese contraseña");
                    txtPassword.Focus();
                }
            }
            else
            {
                MensajeError("Ingrese credenciales");
                txtUsuario.Focus();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
