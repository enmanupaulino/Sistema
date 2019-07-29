﻿using Entidades;
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
    public partial class ReeCliente : Form
    {

        private List<Cliente> ListaCliente;
        public ReeCliente(List<Cliente> clientes)
        {
            this.ListaCliente = clientes;
            InitializeComponent();

        }



        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReCliente reCliente = new ReCliente();
            reCliente.SetDataSource(ListaCliente);
            crystalReportViewer1.ReportSource = reCliente;
            crystalReportViewer1.Refresh();
        }
    }
}
