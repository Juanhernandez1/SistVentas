namespace CapaPresentacion
{
    partial class FrmListadoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECTOR_COMERCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(530, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(614, 56);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(517, 26);
            this.txtBuscar.TabIndex = 64;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 3;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 50D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(919, 468);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(212, 40);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 3;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 50D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(699, 468);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(212, 40);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnNuevo.Location = new System.Drawing.Point(479, 468);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(212, 40);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.RAZON_SOCIAL,
            this.SECTOR_COMERCIAL,
            this.TIPO_DOCUMENTO,
            this.NUMERO_DOCUMENTO,
            this.DIRECCION,
            this.TELEFONO,
            this.EMAIL});
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.SteelBlue;
            this.DataListado.Location = new System.Drawing.Point(12, 93);
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
            this.DataListado.Size = new System.Drawing.Size(1119, 367);
            this.DataListado.TabIndex = 53;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_proveedor";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.DataPropertyName = "razon_social";
            this.RAZON_SOCIAL.HeaderText = "RAZON SOCIAL";
            this.RAZON_SOCIAL.MinimumWidth = 8;
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            // 
            // SECTOR_COMERCIAL
            // 
            this.SECTOR_COMERCIAL.DataPropertyName = "sector_comercial";
            this.SECTOR_COMERCIAL.HeaderText = "SECTOR COMERCIAL";
            this.SECTOR_COMERCIAL.MinimumWidth = 8;
            this.SECTOR_COMERCIAL.Name = "SECTOR_COMERCIAL";
            this.SECTOR_COMERCIAL.ReadOnly = true;
            // 
            // TIPO_DOCUMENTO
            // 
            this.TIPO_DOCUMENTO.DataPropertyName = "tipo_documento";
            this.TIPO_DOCUMENTO.HeaderText = "TIPO DOCUMENTO";
            this.TIPO_DOCUMENTO.MinimumWidth = 8;
            this.TIPO_DOCUMENTO.Name = "TIPO_DOCUMENTO";
            this.TIPO_DOCUMENTO.ReadOnly = true;
            // 
            // NUMERO_DOCUMENTO
            // 
            this.NUMERO_DOCUMENTO.DataPropertyName = "numero_documento";
            this.NUMERO_DOCUMENTO.HeaderText = "NUMERO DOCUMENTO";
            this.NUMERO_DOCUMENTO.MinimumWidth = 8;
            this.NUMERO_DOCUMENTO.Name = "NUMERO_DOCUMENTO";
            this.NUMERO_DOCUMENTO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "direccion";
            this.DIRECCION.HeaderText = "DIRECIÓN";
            this.DIRECCION.MinimumWidth = 8;
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "telefono";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 8;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "email";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 8;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Listado de Proveedores";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1091, 10);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(40, 40);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 51;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // FrmListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1143, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.DataListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECTOR_COMERCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}