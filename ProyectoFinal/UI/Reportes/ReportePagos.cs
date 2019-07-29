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
    public partial class ReportePagos : Form
    {
        private List<Pagos> Listapagos;
        public ReportePagos(List<Pagos> pagos)

        {
            this.Listapagos = pagos;
            InitializeComponent();

        }




        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            RePagoCliente pagoCliente = new RePagoCliente();
            pagoCliente.SetDataSource(Listapagos);
            crystalReportViewer1.ReportSource = Listapagos;
            crystalReportViewer1.Refresh();
        }
    }
}
