
using BLL;
using DAL;
using Entidades;
using System;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroEntradaArticulos : Form
    {
        public RegistroEntradaArticulos()
        {
            InitializeComponent();
            LlenarComboBox();
            Limpiar();
        }
        private void LlenarComboBox()
        {
            Repositorio<Articulos> repositori = new Repositorio<Articulos>(new Contexto());
            ArticulocomboBox.DataSource = repositori.GetList(c => true /* c.PrecioCompra == 0*/);
            ArticulocomboBox.ValueMember = "ArticuloID";
            ArticulocomboBox.DisplayMember = "Nombre";
        }
        private EntradaArticulos LlenarClase()
        {

            EntradaArticulos articulo = new EntradaArticulos();
            articulo.EntradaArticulosID = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);
            articulo.Articulo = ArticulocomboBox.Text;
            articulo.Cantidad = Convert.ToInt32(CantidadArticulonumericUpDown.Value);
            articulo.ArticuloID = Convert.ToInt32(ArticulocomboBox.SelectedValue);
            articulo.PrecioCompra = Convert.ToDecimal(PrecioCompranumericUpDown.Value);
            articulo.PrecioVenta = Convert.ToDecimal(PrecioVentanumericUpDown.Value);
            articulo.Ganancia = Convert.ToDecimal(GananciaTextBox.Text);

            return articulo;
        }
        private bool Validar(int validar)
        {

            bool paso = false;
            if (validar == 1 && EntradaArticuloIDnumericUpDown.Value == 0)
            {
                EntradaerrorProvider.SetError(EntradaArticuloIDnumericUpDown, "Ingrese un ID");
                paso = true;
            }
            if (validar == 2 && ArticulocomboBox.Text == string.Empty)
            {
                EntradaerrorProvider.SetError(ArticulocomboBox, "Ingrese un Articulo");
                paso = true;
            }
            if (validar == 2 && Convert.ToDecimal(PrecioCompranumericUpDown.Value) > Convert.ToDecimal(PrecioVentanumericUpDown.Value))
            {
                EntradaerrorProvider.SetError(PrecioCompranumericUpDown, "El precio de la venta debe ser mayor a compra");
                paso = true;
            }
            if (validar == 2 && CantidadArticulonumericUpDown.Value == 0)
            {
                EntradaerrorProvider.SetError(CantidadArticulonumericUpDown, "Ingrese una Cantidad");
                paso = true;
            }
            if (validar == 2 && PrecioCompranumericUpDown.Value == 0)
            {
                EntradaerrorProvider.SetError(PrecioCompranumericUpDown, "Ingrese un Precio de compra");
                paso = true;
            }
            if (validar == 2 && PrecioVentanumericUpDown.Value == 0)
            {
                EntradaerrorProvider.SetError(PrecioVentanumericUpDown, "Ingrese un Precio de Venta");
                paso = true;
            }
            return paso;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaArticulos entradaArticulos = LlenarClase();
            if (Validar(2))
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }
            if (EntradaArticuloIDnumericUpDown.Value == 0)
            {
                paso = EntradaArticulosBLL.Guardar(entradaArticulos);
            }
            else
            {
                var E = EntradaArticulosBLL.Buscar(Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value));

                if (E != null)
                {
                    paso = EntradaArticulosBLL.Modificar(entradaArticulos);
                }
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }
            int id = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);

            if (BLL.EntradaArticulosBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }
            int id = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);
            EntradaArticulos articulo = BLL.EntradaArticulosBLL.Buscar(id);

            if (articulo != null)         
                LlenaCampo(articulo);
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            EntradaerrorProvider.Clear();
            EntradaArticuloIDnumericUpDown.Value = 0;
            CantidadArticulonumericUpDown.Value = 0;
            ArticulocomboBox.Text.ToString();
            PrecioCompranumericUpDown.Value = 0;
            PrecioVentanumericUpDown.Value = 0;
            GananciaTextBox.Text = 0.ToString();
            EntradaerrorProvider.Clear();
            LlenarComboBox();
        }
        private void LlenaCampo(EntradaArticulos articulo)
        {
            ArticulocomboBox.Text = articulo.Articulo;       
            GananciaTextBox.Text = articulo.Ganancia.ToString();
            CantidadArticulonumericUpDown.Value = articulo.Cantidad;
            PrecioVentanumericUpDown.Value = articulo.PrecioVenta;
            PrecioCompranumericUpDown.Value = articulo.PrecioCompra;       
        }
        private void PrecioCompranumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidarGanancia())
                return;
            GananciaTextBox_TextChanged(sender, e);
        }
        private bool ValidarGanancia()
        {
            decimal Compra = Convert.ToDecimal(PrecioCompranumericUpDown.Value);
            decimal Venta = Convert.ToDecimal(PrecioVentanumericUpDown.Value);
            bool paso = true;
            if (Compra > Venta)
            {
                EntradaerrorProvider.SetError(PrecioCompranumericUpDown, "El precio de compra no puede ser mayor a venta");
                paso = false;
            }
            return paso;
                
        }

        private void GananciaTextBox_TextChanged(object sender, EventArgs e)
        {
            GananciaTextBox.Text = EntradaArticulosBLL.CalcularGanancia(PrecioVentanumericUpDown.Value, PrecioCompranumericUpDown.Value).ToString();
        }

        private void PrecioVentanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidarGanancia())
                return;
            GananciaTextBox_TextChanged(sender, e);
        }
    }
}

