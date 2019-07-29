﻿using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaPago : Form
    {
        List<Pagos> pagos = new List<Pagos>();
        private List<Pagos> ListaPagos;
        public ConsultaPago()
        {
            InitializeComponent();
            
        }
        Expression<Func<Pagos, bool>> filtrar = x => true;

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            if (SetError(2))
            {
                MessageBox.Show("Debe introducir porque filtro va a consultar", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            int id;
            switch (TipocomboBox.SelectedIndex)
            {


                //ID
                case 0:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.PagoID == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;

                //Listar Todo
                case 1:

                    filtrar = t => true;
                    break;
            }

            pagos = PagosBLL.GetList(filtrar);

            ConsultadataGridView.DataSource = pagos;

             if (FechaCheckBox.Checked == true)
                 {
                     pagos = PagosBLL.GetList(filtrar).Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = pagos;
                 }
                 else
                 {
                     pagos = PagosBLL.GetList(filtrar);
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = pagos;
                 }
                 
        }
private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                PagoerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && TipocomboBox.SelectedIndex == 0)
            {
                PagoerrorProvider.SetError(TipocomboBox, "Debe introducir porque filtro va a consultar");
            }
                return paso;
            
        }

        private void LimpiarError()
        {
            PagoerrorProvider.Clear();
        }

        private void ConsultaPago_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FechaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FechaCheckBox.Checked == true)
            {
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
            }
            else
            {
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("no hay datos para imprimir");
                return;
            }
            else
            {
                ReportePagos report = new ReportePagos(ListaPagos);
                report.ShowDialog();
            }
        }

        /*  private void ReporteButton_Click(object sender, EventArgs e)
          {
              if (pagos.Count == 0)
              {
                  MessageBox.Show("No hay datos");
                  return;
              }

              ReportePago reporte = new ReportePago(pagos);
              reporte.ShowDialog();

          }*/
    }
}

