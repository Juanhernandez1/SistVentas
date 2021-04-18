namespace CapaPresentacion
{
    partial class FrmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarproveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFechaVence = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarproducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtFechProduccion = new System.Windows.Forms.DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.DataDetalle = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPFecha
            // 
            this.dTPFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFecha.Location = new System.Drawing.Point(801, 36);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(148, 26);
            this.dTPFecha.TabIndex = 177;
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.cbTipoComprobante.ForeColor = System.Drawing.Color.Black;
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "TICKET"});
            this.cbTipoComprobante.Location = new System.Drawing.Point(159, 79);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(178, 28);
            this.cbTipoComprobante.TabIndex = 176;
            this.cbTipoComprobante.Text = "FACTURA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(709, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 171;
            this.label8.Text = "Fecha ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 25);
            this.label7.TabIndex = 170;
            this.label7.Text = "Comprobante";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(55, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(61, 26);
            this.txtID.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 163;
            this.label2.Text = "ID";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1113, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(42, 42);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 151;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1155, 45);
            this.lblTitulo.TabIndex = 154;
            this.lblTitulo.Text = "MANTENIMIENTO DE COMPRAS || EMISION DE COMPROBANTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.BorderRadius = 3;
            this.btnQuitar.ButtonText = "";
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Iconimage")));
            this.btnQuitar.Iconimage_right = null;
            this.btnQuitar.Iconimage_right_Selected = null;
            this.btnQuitar.Iconimage_Selected = null;
            this.btnQuitar.IconMarginLeft = 0;
            this.btnQuitar.IconMarginRight = 0;
            this.btnQuitar.IconRightVisible = true;
            this.btnQuitar.IconRightZoom = 0D;
            this.btnQuitar.IconVisible = true;
            this.btnQuitar.IconZoom = 50D;
            this.btnQuitar.IsTab = false;
            this.btnQuitar.Location = new System.Drawing.Point(1065, 30);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnQuitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnQuitar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuitar.selected = false;
            this.btnQuitar.Size = new System.Drawing.Size(60, 60);
            this.btnQuitar.TabIndex = 153;
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitar.Textcolor = System.Drawing.Color.White;
            this.btnQuitar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 3;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(694, 648);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(210, 60);
            this.btnGuardar.TabIndex = 152;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdProveedor);
            this.groupBox1.Controls.Add(this.btnBuscarproveedor);
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCorrelativo);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTipoComprobante);
            this.groupBox1.Controls.Add(this.dTPFecha);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 124);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante de Compra";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtIdProveedor.Location = new System.Drawing.Point(640, 35);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(33, 26);
            this.txtIdProveedor.TabIndex = 199;
            // 
            // btnBuscarproveedor
            // 
            this.btnBuscarproveedor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnBuscarproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarproveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarproveedor.BorderRadius = 3;
            this.btnBuscarproveedor.ButtonText = "";
            this.btnBuscarproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarproveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarproveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarproveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarproveedor.Iconimage")));
            this.btnBuscarproveedor.Iconimage_right = null;
            this.btnBuscarproveedor.Iconimage_right_Selected = null;
            this.btnBuscarproveedor.Iconimage_Selected = null;
            this.btnBuscarproveedor.IconMarginLeft = 0;
            this.btnBuscarproveedor.IconMarginRight = 0;
            this.btnBuscarproveedor.IconRightVisible = true;
            this.btnBuscarproveedor.IconRightZoom = 0D;
            this.btnBuscarproveedor.IconVisible = true;
            this.btnBuscarproveedor.IconZoom = 45D;
            this.btnBuscarproveedor.IsTab = false;
            this.btnBuscarproveedor.Location = new System.Drawing.Point(583, 33);
            this.btnBuscarproveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarproveedor.Name = "btnBuscarproveedor";
            this.btnBuscarproveedor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarproveedor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnBuscarproveedor.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarproveedor.selected = false;
            this.btnBuscarproveedor.Size = new System.Drawing.Size(41, 29);
            this.btnBuscarproveedor.TabIndex = 198;
            this.btnBuscarproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarproveedor.Textcolor = System.Drawing.Color.White;
            this.btnBuscarproveedor.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarproveedor.Click += new System.EventHandler(this.btnBuscarproveedor_Click);
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.SystemColors.Control;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Location = new System.Drawing.Point(907, 81);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(91, 26);
            this.txtIva.TabIndex = 192;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(857, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 191;
            this.label9.Text = "Iva";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.Control;
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.ForeColor = System.Drawing.Color.Black;
            this.txtSerie.Location = new System.Drawing.Point(444, 81);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(132, 26);
            this.txtSerie.TabIndex = 189;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(379, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 188;
            this.label3.Text = "Serie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label10.Location = new System.Drawing.Point(587, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 179;
            this.label10.Text = "Correlativo";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativo.ForeColor = System.Drawing.Color.Black;
            this.txtCorrelativo.Location = new System.Drawing.Point(713, 81);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(111, 26);
            this.txtCorrelativo.TabIndex = 180;
            this.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtProveedor.Location = new System.Drawing.Point(261, 35);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(312, 26);
            this.txtProveedor.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(145, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 168;
            this.label5.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdProducto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dtFechaVence);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscarproducto);
            this.groupBox2.Controls.Add(this.dtFechProduccion);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.txtPrecioVenta);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.DataDetalle);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1132, 448);
            this.groupBox2.TabIndex = 180;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Compra";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.ForeColor = System.Drawing.Color.Black;
            this.txtIdProducto.Location = new System.Drawing.Point(159, 21);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(61, 26);
            this.txtIdProducto.TabIndex = 200;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 206;
            this.label14.Text = "Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(803, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 205;
            this.label13.Text = "Fecha Vencimiento";
            // 
            // dtFechaVence
            // 
            this.dtFechaVence.CalendarForeColor = System.Drawing.Color.Black;
            this.dtFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVence.Location = new System.Drawing.Point(807, 56);
            this.dtFechaVence.Name = "dtFechaVence";
            this.dtFechaVence.Size = new System.Drawing.Size(142, 26);
            this.dtFechaVence.TabIndex = 204;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(638, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 203;
            this.label12.Text = "Fecha Producción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 202;
            this.label11.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 201;
            this.label6.Text = "Precio venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 200;
            this.label1.Text = "Precio compra";
            // 
            // btnBuscarproducto
            // 
            this.btnBuscarproducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnBuscarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarproducto.BorderRadius = 3;
            this.btnBuscarproducto.ButtonText = "";
            this.btnBuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarproducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarproducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarproducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarproducto.Iconimage")));
            this.btnBuscarproducto.Iconimage_right = null;
            this.btnBuscarproducto.Iconimage_right_Selected = null;
            this.btnBuscarproducto.Iconimage_Selected = null;
            this.btnBuscarproducto.IconMarginLeft = 0;
            this.btnBuscarproducto.IconMarginRight = 0;
            this.btnBuscarproducto.IconRightVisible = true;
            this.btnBuscarproducto.IconRightZoom = 0D;
            this.btnBuscarproducto.IconVisible = true;
            this.btnBuscarproducto.IconZoom = 40D;
            this.btnBuscarproducto.IsTab = false;
            this.btnBuscarproducto.Location = new System.Drawing.Point(245, 56);
            this.btnBuscarproducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarproducto.Name = "btnBuscarproducto";
            this.btnBuscarproducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarproducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnBuscarproducto.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarproducto.selected = false;
            this.btnBuscarproducto.Size = new System.Drawing.Size(33, 27);
            this.btnBuscarproducto.TabIndex = 199;
            this.btnBuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarproducto.Textcolor = System.Drawing.Color.White;
            this.btnBuscarproducto.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarproducto.Click += new System.EventHandler(this.btnBuscarproducto_Click);
            // 
            // dtFechProduccion
            // 
            this.dtFechProduccion.CalendarForeColor = System.Drawing.Color.Black;
            this.dtFechProduccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechProduccion.Location = new System.Drawing.Point(642, 56);
            this.dtFechProduccion.Name = "dtFechProduccion";
            this.dtFechProduccion.Size = new System.Drawing.Size(142, 26);
            this.dtFechProduccion.TabIndex = 193;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(285, 56);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(105, 26);
            this.txtStock.TabIndex = 196;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioVenta.Location = new System.Drawing.Point(527, 56);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(105, 26);
            this.txtPrecioVenta.TabIndex = 195;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioCompra.Location = new System.Drawing.Point(405, 56);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(105, 26);
            this.txtPrecioCompra.TabIndex = 194;
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.ForeColor = System.Drawing.Color.Black;
            this.txtProducto.Location = new System.Drawing.Point(13, 56);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(225, 26);
            this.txtProducto.TabIndex = 193;
            // 
            // DataDetalle
            // 
            this.DataDetalle.AllowUserToAddRows = false;
            this.DataDetalle.AllowUserToDeleteRows = false;
            this.DataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalle.Location = new System.Drawing.Point(6, 108);
            this.DataDetalle.Name = "DataDetalle";
            this.DataDetalle.RowHeadersWidth = 62;
            this.DataDetalle.RowTemplate.Height = 28;
            this.DataDetalle.Size = new System.Drawing.Size(1120, 328);
            this.DataDetalle.TabIndex = 182;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 3;
            this.btnAgregar.ButtonText = "";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 50D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(978, 29);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 181;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 637);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 84);
            this.groupBox3.TabIndex = 181;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liquidación";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.lblTotal.Location = new System.Drawing.Point(257, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 32);
            this.lblTotal.TabIndex = 184;
            this.lblTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(44, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 193;
            this.label4.Text = "Total Pagado $";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnGuardar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnQuitar;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.btnAgregar;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 3;
            this.btnNuevo.ButtonText = "NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 50D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(464, 648);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(210, 60);
            this.btnNuevo.TabIndex = 182;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 3;
            this.btnCancelar.ButtonText = "CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(928, 645);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(210, 60);
            this.btnCancelar.TabIndex = 183;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.btnNuevo;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.btnCancelar;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 737);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1155, 900);
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dTPFecha;
        public System.Windows.Forms.ComboBox cbTipoComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        public System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.TextBox txtPrecioCompra;
        public System.Windows.Forms.TextBox txtProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarproveedor;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dtFechaVence;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarproducto;
        public System.Windows.Forms.DateTimePicker dtFechProduccion;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.TextBox txtIdProveedor;
        public System.Windows.Forms.TextBox txtIdProducto;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.DataGridView DataDetalle;
    }
}