
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
    public partial class ConsultaArticulos : Form
    {

        List<Articulos> articulos = new List<Articulos>();
        private List<Articulos> ListaArticulo;
        public ConsultaArticulos()
        {
            InitializeComponent();
        }
        Expression<Func<Articulos, bool>> filtrar = x => true;

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
                    filtrar = t => t.ArticuloID == id&& (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
               
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Nombre == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year); 
                    break;
                //Marca
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Marca == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                
                //Listar Todo
                case 4:

                    filtrar = t => true;
                    break;
            }

            articulos = ArticulosBLL.GetList(filtrar);

            ConsultadataGridView.DataSource =articulos;

            if (FechaCheckBox.Checked == true)
            {
                articulos = ArticulosBLL.GetList(filtrar).Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = articulos;
            }
            else
            {
                articulos = ArticulosBLL.GetList(filtrar);
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = articulos;
            }
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                ArticuloerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                ArticuloerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            ArticuloerrorProvider.Clear();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Consultabutton_Click_1(object sender, EventArgs e)
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
                    filtrar = t => t.ArticuloID == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;

                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Nombre == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                //Marca
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Marca == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;

                //Listar Todo
                case 4:

                    filtrar = t => true;
                    break;
            }

            articulos = ArticulosBLL.GetList(filtrar);

            ConsultadataGridView.DataSource = articulos;

            if (FechaCheckBox.Checked == true)
            {
                articulos = ArticulosBLL.GetList(filtrar).Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = articulos;
            }
            else
            {
                articulos = ArticulosBLL.GetList(filtrar);
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = articulos;
            }
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
                ReporteArticulo report = new ReporteArticulo(ListaArticulo);
                report.ShowDialog();
            }
        }

        /* private void ReporteButton_Click(object sender, EventArgs e)
         {
             if (articulos.Count() == 0)
             {
                 MessageBox.Show("el grid esta vacio", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else {
                     ReporteArticulos abrir = new ReporteArticulos(articulos);
                            abrir.ShowDialog();
             }


         }*/
    }
    
}
