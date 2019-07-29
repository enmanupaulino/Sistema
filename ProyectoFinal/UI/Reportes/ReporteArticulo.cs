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
    public partial class ReporteArticulo : Form
    {
       

        private List<Articulos> ListaArticulo;
        public ReporteArticulo(List<Articulos> articulos)
        {
            this.ListaArticulo = articulos;
            InitializeComponent();

        }

      


        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReArticulos reArticulos = new ReArticulos();
            reArticulos.SetDataSource(ListaArticulo);
            crystalReportViewer1.ReportSource = ListaArticulo;
            crystalReportViewer1.Refresh();
        }
    }
}
