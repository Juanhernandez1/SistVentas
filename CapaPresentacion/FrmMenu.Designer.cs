namespace CapaPresentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btbCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPresentacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelPrincipal.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbCerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.panelContenedor);
            this.PanelPrincipal.Controls.Add(this.PanelInferior);
            this.PanelPrincipal.Controls.Add(this.PanelSuperior);
            this.PanelPrincipal.Controls.Add(this.PanelMenu);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1600, 900);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedor.Location = new System.Drawing.Point(233, 86);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1364, 708);
            this.panelContenedor.TabIndex = 3;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(230, 800);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(1370, 100);
            this.PanelInferior.TabIndex = 2;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(59)))), ((int)(((byte)(101)))));
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnRestaurar);
            this.PanelSuperior.Controls.Add(this.btnMaximizar);
            this.PanelSuperior.Controls.Add(this.btbCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(230, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1370, 80);
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(1169, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(59, 59);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(1234, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(59, 59);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(1234, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(59, 59);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btbCerrar
            // 
            this.btbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btbCerrar.Image")));
            this.btbCerrar.ImageActive = null;
            this.btbCerrar.Location = new System.Drawing.Point(1299, 6);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(59, 59);
            this.btbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbCerrar.TabIndex = 0;
            this.btbCerrar.TabStop = false;
            this.btbCerrar.Zoom = 10;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.lblAcceso);
            this.PanelMenu.Controls.Add(this.lblUsuario);
            this.PanelMenu.Controls.Add(this.bunifuSeparator1);
            this.PanelMenu.Controls.Add(this.btnVentas);
            this.PanelMenu.Controls.Add(this.btnCompras);
            this.PanelMenu.Controls.Add(this.btnEmpleado);
            this.PanelMenu.Controls.Add(this.btnProveedor);
            this.PanelMenu.Controls.Add(this.btnProductos);
            this.PanelMenu.Controls.Add(this.btnPresentacion);
            this.PanelMenu.Controls.Add(this.btnCategoria);
            this.PanelMenu.Controls.Add(this.bunifuImageButton5);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 900);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveBorderThickness = 1;
            this.btnSalir.ActiveCornerRadius = 20;
            this.btnSalir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 20;
            this.btnSalir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSalir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.Location = new System.Drawing.Point(24, 109);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.ForeColor = System.Drawing.Color.White;
            this.lblAcceso.Location = new System.Drawing.Point(75, 45);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(62, 20);
            this.lblAcceso.TabIndex = 13;
            this.lblAcceso.Text = "Acceso";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(73, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 141);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(226, 54);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 60D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(0, 522);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(230, 45);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = null;
            this.btnCompras.Iconimage_right_Selected = null;
            this.btnCompras.Iconimage_Selected = null;
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 60D;
            this.btnCompras.IsTab = false;
            this.btnCompras.Location = new System.Drawing.Point(0, 467);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(230, 45);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.Textcolor = System.Drawing.Color.White;
            this.btnCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleado.BorderRadius = 0;
            this.btnEmpleado.ButtonText = "EMPLEADO";
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Iconimage")));
            this.btnEmpleado.Iconimage_right = null;
            this.btnEmpleado.Iconimage_right_Selected = null;
            this.btnEmpleado.Iconimage_Selected = null;
            this.btnEmpleado.IconMarginLeft = 0;
            this.btnEmpleado.IconMarginRight = 0;
            this.btnEmpleado.IconRightVisible = true;
            this.btnEmpleado.IconRightZoom = 0D;
            this.btnEmpleado.IconVisible = true;
            this.btnEmpleado.IconZoom = 60D;
            this.btnEmpleado.IsTab = false;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 412);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEmpleado.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpleado.selected = false;
            this.btnEmpleado.Size = new System.Drawing.Size(230, 45);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Activecolor = System.Drawing.Color.Transparent;
            this.btnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedor.BorderRadius = 0;
            this.btnProveedor.ButtonText = "PROVEEDOR";
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btnProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Iconimage")));
            this.btnProveedor.Iconimage_right = null;
            this.btnProveedor.Iconimage_right_Selected = null;
            this.btnProveedor.Iconimage_Selected = null;
            this.btnProveedor.IconMarginLeft = 0;
            this.btnProveedor.IconMarginRight = 0;
            this.btnProveedor.IconRightVisible = true;
            this.btnProveedor.IconRightZoom = 0D;
            this.btnProveedor.IconVisible = true;
            this.btnProveedor.IconZoom = 60D;
            this.btnProveedor.IsTab = false;
            this.btnProveedor.Location = new System.Drawing.Point(0, 357);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProveedor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnProveedor.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedor.selected = false;
            this.btnProveedor.Size = new System.Drawing.Size(230, 45);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedor.Textcolor = System.Drawing.Color.White;
            this.btnProveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 60D;
            this.btnProductos.IsTab = false;
            this.btnProductos.Location = new System.Drawing.Point(0, 302);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(230, 45);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.Textcolor = System.Drawing.Color.White;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.Activecolor = System.Drawing.Color.Transparent;
            this.btnPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.btnPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPresentacion.BorderRadius = 0;
            this.btnPresentacion.ButtonText = "PRESENTACIÓN";
            this.btnPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresentacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnPresentacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPresentacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPresentacion.Iconimage")));
            this.btnPresentacion.Iconimage_right = null;
            this.btnPresentacion.Iconimage_right_Selected = null;
            this.btnPresentacion.Iconimage_Selected = null;
            this.btnPresentacion.IconMarginLeft = 0;
            this.btnPresentacion.IconMarginRight = 0;
            this.btnPresentacion.IconRightVisible = true;
            this.btnPresentacion.IconRightZoom = 0D;
            this.btnPresentacion.IconVisible = true;
            this.btnPresentacion.IconZoom = 60D;
            this.btnPresentacion.IsTab = false;
            this.btnPresentacion.Location = new System.Drawing.Point(0, 247);
            this.btnPresentacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPresentacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnPresentacion.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPresentacion.selected = false;
            this.btnPresentacion.Size = new System.Drawing.Size(230, 45);
            this.btnPresentacion.TabIndex = 1;
            this.btnPresentacion.Text = "PRESENTACIÓN";
            this.btnPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresentacion.Textcolor = System.Drawing.Color.White;
            this.btnPresentacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresentacion.Click += new System.EventHandler(this.btnPresentacion_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Activecolor = System.Drawing.Color.Transparent;
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategoria.BorderRadius = 0;
            this.btnCategoria.ButtonText = "CATEGORIAS";
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Iconimage")));
            this.btnCategoria.Iconimage_right = null;
            this.btnCategoria.Iconimage_right_Selected = null;
            this.btnCategoria.Iconimage_Selected = null;
            this.btnCategoria.IconMarginLeft = 0;
            this.btnCategoria.IconMarginRight = 0;
            this.btnCategoria.IconRightVisible = true;
            this.btnCategoria.IconRightZoom = 0D;
            this.btnCategoria.IconVisible = true;
            this.btnCategoria.IconZoom = 60D;
            this.btnCategoria.IsTab = false;
            this.btnCategoria.Location = new System.Drawing.Point(0, 192);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnCategoria.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCategoria.selected = false;
            this.btnCategoria.Size = new System.Drawing.Size(230, 45);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "CATEGORIAS";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.Textcolor = System.Drawing.Color.White;
            this.btnCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(55, 68);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 4;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.panelContenedor;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelSuperior;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbCerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btbCerrar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnProveedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnPresentacion;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategoria;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Label lblUsuario;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}