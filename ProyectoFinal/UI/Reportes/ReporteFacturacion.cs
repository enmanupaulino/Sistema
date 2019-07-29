using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteFacturacion : Form
    {
        private List<Facturacion> ListaFacturacion;
        public ReporteFacturacion(List<Facturacion> facturacions)
        {
            this.ListaFacturacion = facturacions;
            InitializeComponent();

        }




        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReFacturacion reFacturacion = new ReFacturacion();
            reFacturacion.SetDataSource(ListaFacturacion);
            crystalReportViewer1.ReportSource = ListaFacturacion;
            crystalReportViewer1.Refresh();
        }

        private void CrystalReportViewer2_Load(object sender, EventArgs e)
        {
            ReFacturacion reFacturacion = new ReFacturacion();
            reFacturacion.SetDataSource(ListaFacturacion);
            crystalReportViewer1.ReportSource = ListaFacturacion;
            crystalReportViewer1.Refresh();
        }
    }
}
