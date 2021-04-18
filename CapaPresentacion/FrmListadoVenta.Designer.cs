namespace CapaPresentacion
{
    partial class FrmListadoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFiltrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORRELATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
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
            this.btnActualizar.Location = new System.Drawing.Point(424, 102);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnActualizar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(42, 40);
            this.btnActualizar.TabIndex = 105;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Textcolor = System.Drawing.Color.White;
            this.btnActualizar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnFiltrar.Location = new System.Drawing.Point(374, 102);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnFiltrar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.selected = false;
            this.btnFiltrar.Size = new System.Drawing.Size(42, 40);
            this.btnFiltrar.TabIndex = 104;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrar.Textcolor = System.Drawing.Color.White;
            this.btnFiltrar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.btnImprimir.Location = new System.Drawing.Point(917, 102);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(162, 40);
            this.btnImprimir.TabIndex = 103;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnular.BorderRadius = 3;
            this.btnAnular.ButtonText = "ELIMINAR";
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
            this.btnAnular.Location = new System.Drawing.Point(747, 102);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAnular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAnular.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAnular.selected = false;
            this.btnAnular.Size = new System.Drawing.Size(162, 40);
            this.btnAnular.TabIndex = 102;
            this.btnAnular.Text = "ELIMINAR";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.Textcolor = System.Drawing.Color.White;
            this.btnAnular.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Fecha Final";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(197, 116);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(170, 26);
            this.dtFecha2.TabIndex = 100;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(13, 116);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(170, 26);
            this.dtFecha1.TabIndex = 99;
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
            this.btnNuevo.Location = new System.Drawing.Point(577, 102);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(162, 40);
            this.btnNuevo.TabIndex = 98;
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
            this.pbCerrar.Location = new System.Drawing.Point(1039, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(40, 40);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 97;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 26);
            this.label1.TabIndex = 94;
            this.label1.Text = "Listado de Comprobantes de Venta";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.FECHA,
            this.COMPROBANTE,
            this.SERIE,
            this.CORRELATIVO,
            this.CLIENTE,
            this.TOTAL});
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.SteelBlue;
            this.DataListado.Location = new System.Drawing.Point(12, 150);
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
            this.DataListado.Size = new System.Drawing.Size(1067, 491);
            this.DataListado.TabIndex = 95;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_venta";
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
            this.EMPLEADO.DataPropertyName = "Empleado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPLEADO.DefaultCellStyle = dataGridViewCellStyle3;
            this.EMPLEADO.HeaderText = "EMPLEADO";
            this.EMPLEADO.MinimumWidth = 8;
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.ReadOnly = true;
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
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "cliente";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.MinimumWidth = 8;
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "Total";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 8;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Fecha Inicial";
            // 
            // FrmListadoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1091, 659);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha2);
            this.Controls.Add(this.dtFecha1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVenta";
            this.Text = "FrmListadoVenta";
            this.Load += new System.EventHandler(this.FrmListadoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiltrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPROBANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORRELATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label5;
    }
}