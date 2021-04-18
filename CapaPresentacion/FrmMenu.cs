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

using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        //Variables constantes que ayudan a redimencionar el formulario
        private const int tamañogrid = 10;
        private const int areamause = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        /*Variables para botonode maximizar restaurar y minimizar que nos ayudan a guardar el tamaño y coordenadas
        del formulario*/
        //variables para localizacion
        int lx, ly;
        //variables para altura y ancho
        int sw, sh;

        //Variable para el acceso
        public string Acceso = "";

        public FrmMenu()
        {
            InitializeComponent();
        }
        //Metodo para cargar datos de usuario
        private void CargarDatosUsuario()
        {
            
            //lblUsuario.Text = Apellido + " " + Nombre;
            //lblAcceso.Text = Acceso;
            lblUsuario.Text = E_Datos_Login.Apellido;
            lblAcceso.Text = E_Datos_Login.Acceso;
        }
        //Metodo para Acceso de Usuarios, habilitar botones
        private void GestionAcceso()
        {
            if (Acceso=="ADMINISTRADOR")
            {
                btnCategoria.Enabled = true;
                btnPresentacion.Enabled = true;
                btnProductos.Enabled = true;
                btnProveedor.Enabled = true;
                btnEmpleado.Enabled = true;
                btnCompras.Enabled = true;
                btnVentas.Enabled = true;
            }
            else if (Acceso =="VENDEDOR")
            {
                btnCategoria.Enabled = false;
                btnPresentacion.Enabled = false;
                btnProductos.Enabled = false;
                btnProveedor.Enabled = false;
                btnEmpleado.Enabled = false;
                btnCompras.Enabled = false;
                btnVentas.Enabled = true;
            }
            else if (Acceso =="BODEGUERO")
            {
                btnCategoria.Enabled = true;
                btnPresentacion.Enabled = true;
                btnProductos.Enabled = true;
                btnProveedor.Enabled = false;
                btnEmpleado.Enabled = false;
                btnCompras.Enabled = true;
                btnVentas.Enabled = false; 
            }
            else
            {
                if (MessageBox.Show("Acceso denegado","Ferreteria Emanuel",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        //Metodos Para poder mover el formulario haciendo click en la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] 
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);

        //este metodo Nos ayuda a excluir la esquina inferior derecha para redimencionar el formulario
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            //dibuja un rectangulo en la esquina para redimencionar
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            rectangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);

            region.Exclude(rectangulogrid);

            PanelPrincipal.Region = region;

            Invalidate();
        }
        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamause:
                    base.WndProc(ref sms);

                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    if (!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);break;

                default:
                    base.WndProc(ref sms);
                    break;
            }
        }
        //Metodo para dar estilo al rectangulo
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush soliBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            //se esfecifica a que area va afectar 
            e.Graphics.FillRectangle(soliBrush, rectangulogrid);

            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿está seguro de cerrar elmprograma?","Alerta!!!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularios < FrmListaEmpleado>();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmlistadoProducto>();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmListadoIngreso>();            
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmListadoProveedor>();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmCategorias>();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmPresentacion>();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmListadoVenta>();
        }

        private void AbrirFormularios<FormularioAbrir>()where FormularioAbrir : Form, new()
        {
            Form Formularios;
            Formularios = panelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            //Creamos una instancia 
            if (Formularios==null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                panelContenedor.Controls.Add(Formularios);

                panelContenedor.Tag = Formularios;

                Formularios.Show();

                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            GestionAcceso();
        }    
    }
}
