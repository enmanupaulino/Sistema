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
    public partial class Report : Form
    {
        private List<Usuarios> ListaUsuario;
        public Report(List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.ListaUsuario = usuarios;
            
        }
        private void CrystalReportViewer2_Load(object sender, EventArgs e)
        {
            ReUsuario reUsuario = new ReUsuario();
            reUsuario.SetDataSource(ListaUsuario);
            crystalReportViewer2.ReportSource = reUsuario;
            crystalReportViewer2.Refresh();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            CrystalReportViewer2_Load(sender, e);
        }
    }
}
