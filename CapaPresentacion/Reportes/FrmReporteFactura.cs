using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        private int _IdVenta;
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public FrmReporteFactura()
        {
            InitializeComponent();
        }


        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sdPrincipal.sp_reporte_factura1' Puede moverla o quitarla según sea necesario.
                this.sp_reporte_factura1TableAdapter.Fill(this.sdPrincipal.sp_reporte_factura1, IdVenta);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}
