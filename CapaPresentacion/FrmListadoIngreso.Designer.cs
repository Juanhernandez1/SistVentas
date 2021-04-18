namespace CapaPresentacion
{
    partial class FrmListadoIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoIngreso));
            this.label5 = new System.Windows.Forms.Label();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORRELATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFiltrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha Inicial";
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.DataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EMPLEADO,
            this.PROVEEDOR,
            this.FECHA,
            this.COMPROBANTE,
            this.SERIE,
            this.CORRELATIVO,
            this.ESTADO,
            this.TOTAL});
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.SteelBlue;
            this.DataListado.Location = new System.Drawing.Point(12, 144);
            this.DataListado.MultiSelect = false;
            this.DataListado.Name = "DataListado";
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataListado.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DataListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataListado.RowTemplate.Height = 28;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(1119, 491);
            this.DataListado.TabIndex = 31;
            this.DataListado.DoubleClick += new System.EventHandler(this.DataListado_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_ingreso";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.DataPropertyName = "Trabajador";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPLEADO.DefaultCellStyle = dataGridViewCellStyle3;
            this.EMPLEADO.HeaderText = "EMPLEADO";
            this.EMPLEADO.MinimumWidth = 8;
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.ReadOnly = true;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.DataPropertyName = "Proveedor";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.MinimumWidth = 8;
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "fecha";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.MinimumWidth = 8;
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // COMPROBANTE
            // 
            this.COMPROBANTE.DataPropertyName = "tipo_comprobante";
            this.COMPROBANTE.HeaderText = "COMPROBANTE";
            this.COMPROBANTE.MinimumWidth = 8;
            this.COMPROBANTE.Name = "COMPROBANTE";
            this.COMPROBANTE.ReadOnly = true;
            // 
            // SERIE
            // 
            this.SERIE.DataPropertyName = "serie";
            this.SERIE.HeaderText = "SERIE";
            this.SERIE.MinimumWidth = 8;
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            // 
            // CORRELATIVO
            // 
            this.CORRELATIVO.DataPropertyName = "correlativo";
            this.CORRELATIVO.HeaderText = "CORRELATIVO";
            this.CORRELATIVO.MinimumWidth = 8;
            this.CORRELATIVO.Name = "CORRELATIVO";
            this.CORRELATIVO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.MinimumWidth = 8;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "Total";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 8;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Listado de Comprobantes de Compras";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnNuevo.Location = new System.Drawing.Point(666, 96);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(150, 40);
            this.btnNuevo.TabIndex = 85;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1091, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(40, 40);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 84;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(13, 110);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(170, 26);
            this.dtFecha1.TabIndex = 86;
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(197, 110);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(170, 26);
            this.dtFecha2.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Fecha Final";
            // 
            // btnAnular
            // 
            this.btnAnular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnular.BorderRadius = 3;
            this.btnAnular.ButtonText = "ANULAR";
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnular.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAnular.Iconimage")));
            this.btnAnular.Iconimage_right = null;
            this.btnAnular.Iconimage_right_Selected = null;
            this.btnAnular.Iconimage_Selected = null;
            this.btnAnular.IconMarginLeft = 0;
            this.btnAnular.IconMarginRight = 0;
            this.btnAnular.IconRightVisible = true;
            this.btnAnular.IconRightZoom = 0D;
            this.btnAnular.IconVisible = true;
            this.btnAnular.IconZoom = 50D;
            this.btnAnular.IsTab = false;
            this.btnAnular.Location = new System.Drawing.Point(824, 96);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAnular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAnular.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAnular.selected = false;
            this.btnAnular.Size = new System.Drawing.Size(150, 40);
            this.btnAnular.TabIndex = 89;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.Textcolor = System.Drawing.Color.White;
            this.btnAnular.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderRadius = 3;
            this.btnImprimir.ButtonText = "IMPRIMIR";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 40D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(981, 96);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(150, 40);
            this.btnImprimir.TabIndex = 90;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.BorderRadius = 3;
            this.btnFiltrar.ButtonText = "";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiltrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Iconimage")));
            this.btnFiltrar.Iconimage_right = null;
            this.btnFiltrar.Iconimage_right_Selected = null;
            this.btnFiltrar.Iconimage_Selected = null;
            this.btnFiltrar.IconMarginLeft = 0;
            this.btnFiltrar.IconMarginRight = 0;
            this.btnFiltrar.IconRightVisible = true;
            this.btnFiltrar.IconRightZoom = 0D;
            this.btnFiltrar.IconVisible = true;
            this.btnFiltrar.IconZoom = 50D;
            this.btnFiltrar.IsTab = false;
            this.btnFiltrar.Location = new System.Drawing.Point(374, 96);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnFiltrar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.selected = false;
            this.btnFiltrar.Size = new System.Drawing.Size(42, 40);
            this.btnFiltrar.TabIndex = 91;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrar.Textcolor = System.Drawing.Color.White;
            this.btnFiltrar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderRadius = 3;
            this.btnActualizar.ButtonText = "";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Iconimage")));
            this.btnActualizar.Iconimage_right = null;
            this.btnActualizar.Iconimage_right_Selected = null;
            this.btnActualizar.Iconimage_Selected = null;
            this.btnActualizar.IconMarginLeft = 0;
            this.btnActualizar.IconMarginRight = 0;
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconRightZoom = 0D;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.IconZoom = 50D;
            this.btnActualizar.IsTab = false;
            this.btnActualizar.Location = new System.Drawing.Point(424, 96);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnActualizar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(42, 40);
            this.btnActualizar.TabIndex = 93;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Textcolor = System.Drawing.Color.White;
            this.btnActualizar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmListadoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1143, 659);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha2);
            this.Controls.Add(this.dtFecha1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnular;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiltrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPROBANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORRELATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}