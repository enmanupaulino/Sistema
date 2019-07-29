
using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaFacturacion : Form
    {
        List<Facturacion> facturacions = new List<Facturacion>();
        private List<Facturacion> ListaFacturacion;
        public ConsultaFacturacion()
        {
            InitializeComponent();
        }

        Expression<Func<Facturacion, bool>> filtrar = x => true;

        private void Consultabutton_Click(object sender, EventArgs e)
        {
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
                    filtrar = t => t.FacturaID == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
               

                //Listar Todo
                case 1:
                    filtrar = t => true;
                    break;
            }

            
            ConsultadataGridView.DataSource = FacturacionBLL.GetList(filtrar);
            ConsultadataGridView.Columns["Detalle"].Visible = false;
            if (FechaCheckBox.Checked == true)
            {
                facturacions = FacturacionBLL.GetList(filtrar).Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = facturacions;
            }
            else
            {
                facturacions = FacturacionBLL.GetList(filtrar);
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = facturacions;
            }
        }


        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                FacturacionerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                FacturacionerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            FacturacionerrorProvider.Clear();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
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

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
                    filtrar = t => t.FacturaID == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;


                //Listar Todo
                case 1:
                    filtrar = t => true;
                    break;
            }


            ConsultadataGridView.DataSource = FacturacionBLL.GetList(filtrar);
            ConsultadataGridView.Columns["Detalle"].Visible = false;
            if (FechaCheckBox.Checked == true)
            {
                facturacions = FacturacionBLL.GetList(filtrar).Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = facturacions;
            }
            else
            {
                facturacions = FacturacionBLL.GetList(filtrar);
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = facturacions;
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
                ReporteFacturacion report = new ReporteFacturacion(ListaFacturacion);
                report.ShowDialog();
            }
        }

        /*    private void ReporteButton_Click(object sender, EventArgs e)
            {
                Facturacion facturacionn = new Facturacion();
                if (ConsultadataGridView.Rows.Count > 0 && ConsultadataGridView.CurrentRow != null)
                {
                    List<Facturacion> Detalle = (List<Facturacion>)ConsultadataGridView.DataSource;
                    int id = Detalle.ElementAt(ConsultadataGridView.CurrentRow.Index).FacturaID;

                    ReporteFacturacion abrir = new ReporteFacturacion(FacturacionBLL.GetList(x => x.FacturaID == id));
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show("No existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }*/
    }
}
