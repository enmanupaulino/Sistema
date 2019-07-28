
using BLL;
using Entidades;

using System;
using System.Collections.Generic;

using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaEntradaArticulos : Form
    {
        List<EntradaArticulos> entradaArticulos = new List<EntradaArticulos>();
        public ConsultaEntradaArticulos()
        {
            InitializeComponent();
        }

        Expression<Func<EntradaArticulos, bool>> filtrar = x => true;

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
                    filtrar = t => t.EntradaArticulosID == id;
                    break;
                //Codigo Articulo
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Articulo == CriteriotextBox.Text;
                    break;

                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }

            entradaArticulos= EntradaArticulosBLL.GetList(filtrar);

            

        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                EntradaerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                EntradaerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            EntradaerrorProvider.Clear();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FechaCheckBox_CheckedChanged(object sender, EventArgs e)
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
                    filtrar = t => t.EntradaArticulosID == id;
                    break;
                //Codigo Articulo
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Articulo == CriteriotextBox.Text;
                    break;

                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }

            entradaArticulos = EntradaArticulosBLL.GetList(filtrar);
        }

        /* private void ReporteButton_Click(object sender, EventArgs e)
         {
             if (entradaArticulos.Count == 0)
             {
                 MessageBox.Show("No hay datos");
                 return;
             }

             ReporteEntrada reporte = new ReporteEntrada(entradaArticulos);
             reporte.ShowDialog();

         }*/
    }
 }
