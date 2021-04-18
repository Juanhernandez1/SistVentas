namespace CapaPresentacion
{
    partial class FrmVistaProductoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaProductoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_BARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESENTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_ACTUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1136, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(45, 45);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 79;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODIGO_BARRA,
            this.PRODUCTO,
            this.CATEGORIA,
            this.PRESENTACION,
            this.STOCK_ACTUAL,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.FECHA_VENCE});
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.SteelBlue;
            this.DataListado.Location = new System.Drawing.Point(12, 109);
            this.DataListado.MultiSelect = false;
            this.DataListado.Name = "DataListado";
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataListado.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataListado.RowTemplate.Height = 28;
            this.DataListado.Size = new System.Drawing.Size(1157, 417);
            this.DataListado.TabIndex = 81;
            this.DataListado.DoubleClick += new System.EventHandler(this.DataListado_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_detalle_ingreso";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CODIGO_BARRA
            // 
            this.CODIGO_BARRA.DataPropertyName = "codigo_barra";
            this.CODIGO_BARRA.HeaderText = "CODIGO BARRA";
            this.CODIGO_BARRA.MinimumWidth = 8;
            this.CODIGO_BARRA.Name = "CODIGO_BARRA";
            this.CODIGO_BARRA.ReadOnly = true;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.DataPropertyName = "nombre";
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.MinimumWidth = 8;
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "Categoria";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.MinimumWidth = 8;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // PRESENTACION
            // 
            this.PRESENTACION.DataPropertyName = "Presentacion";
            this.PRESENTACION.HeaderText = "PRESENTACION";
            this.PRESENTACION.MinimumWidth = 8;
            this.PRESENTACION.Name = "PRESENTACION";
            this.PRESENTACION.ReadOnly = true;
            // 
            // STOCK_ACTUAL
            // 
            this.STOCK_ACTUAL.DataPropertyName = "stock_actual";
            this.STOCK_ACTUAL.HeaderText = "STOCK";
            this.STOCK_ACTUAL.MinimumWidth = 8;
            this.STOCK_ACTUAL.Name = "STOCK_ACTUAL";
            this.STOCK_ACTUAL.ReadOnly = true;
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.DataPropertyName = "precio_compra";
            this.PRECIO_COMPRA.HeaderText = "PRECIO COMPRA";
            this.PRECIO_COMPRA.MinimumWidth = 8;
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.ReadOnly = true;
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.DataPropertyName = "precio_venta";
            this.PRECIO_VENTA.HeaderText = "PRECIO VENTA";
            this.PRECIO_VENTA.MinimumWidth = 8;
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            this.PRECIO_VENTA.ReadOnly = true;
            // 
            // FECHA_VENCE
            // 
            this.FECHA_VENCE.DataPropertyName = "fecha_vence";
            this.FECHA_VENCE.HeaderText = "VECIMIENTO";
            this.FECHA_VENCE.MinimumWidth = 8;
            this.FECHA_VENCE.Name = "FECHA_VENCE";
            this.FECHA_VENCE.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 26);
            this.label1.TabIndex = 82;
            this.label1.Text = "Listado de Productos para la Venta";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(587, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(701, 66);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(468, 26);
            this.txtBuscar.TabIndex = 94;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.lblTitulo.Size = new System.Drawing.Size(1181, 45);
            this.lblTitulo.TabIndex = 187;
            this.lblTitulo.Text = "SELECCIONE UN PRODUCTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmVistaProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1181, 563);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaProductoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVistaProductoVenta";
            this.Load += new System.EventHandler(this.FrmVistaProductoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_BARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESENTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_ACTUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENCE;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}