namespace CapaPresentacion
{
    partial class FrmVistaProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaProveedor));
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECTOR_COMERCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "email";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 8;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 150;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "telefono";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 8;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 150;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "direccion";
            this.DIRECCION.HeaderText = "DIRECIÓN";
            this.DIRECCION.MinimumWidth = 8;
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 150;
            // 
            // NUMERO_DOCUMENTO
            // 
            this.NUMERO_DOCUMENTO.DataPropertyName = "numero_documento";
            this.NUMERO_DOCUMENTO.HeaderText = "NUMERO DOCUMENTO";
            this.NUMERO_DOCUMENTO.MinimumWidth = 8;
            this.NUMERO_DOCUMENTO.Name = "NUMERO_DOCUMENTO";
            this.NUMERO_DOCUMENTO.ReadOnly = true;
            this.NUMERO_DOCUMENTO.Width = 190;
            // 
            // TIPO_DOCUMENTO
            // 
            this.TIPO_DOCUMENTO.DataPropertyName = "tipo_documento";
            this.TIPO_DOCUMENTO.HeaderText = "TIPO DOCUMENTO";
            this.TIPO_DOCUMENTO.MinimumWidth = 8;
            this.TIPO_DOCUMENTO.Name = "TIPO_DOCUMENTO";
            this.TIPO_DOCUMENTO.ReadOnly = true;
            this.TIPO_DOCUMENTO.Width = 170;
            // 
            // SECTOR_COMERCIAL
            // 
            this.SECTOR_COMERCIAL.DataPropertyName = "sector_comercial";
            this.SECTOR_COMERCIAL.HeaderText = "SECTOR COMERCIAL";
            this.SECTOR_COMERCIAL.MinimumWidth = 8;
            this.SECTOR_COMERCIAL.Name = "SECTOR_COMERCIAL";
            this.SECTOR_COMERCIAL.ReadOnly = true;
            this.SECTOR_COMERCIAL.Width = 170;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.DataPropertyName = "razon_social";
            this.RAZON_SOCIAL.HeaderText = "RAZON SOCIAL";
            this.RAZON_SOCIAL.MinimumWidth = 8;
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            this.RAZON_SOCIAL.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_proveedor";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(606, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(701, 68);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(468, 26);
            this.txtBuscar.TabIndex = 91;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToOrderColumns = true;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.RAZON_SOCIAL,
            this.SECTOR_COMERCIAL,
            this.TIPO_DOCUMENTO,
            this.NUMERO_DOCUMENTO,
            this.DIRECCION,
            this.TELEFONO,
            this.EMAIL});
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
            this.DataListado.TabIndex = 80;
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 79;
            this.label1.Text = "Listado de Proveedores";
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1136, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(45, 45);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 78;
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
            this.lblTitulo.Size = new System.Drawing.Size(1181, 45);
            this.lblTitulo.TabIndex = 188;
            this.lblTitulo.Text = "SELECCIONE UN PROveedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmVistaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1181, 563);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaProveedor";
            this.Text = "FrmVistaProveedor";
            this.Load += new System.EventHandler(this.FrmVistaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECTOR_COMERCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblTitulo;
    }
}