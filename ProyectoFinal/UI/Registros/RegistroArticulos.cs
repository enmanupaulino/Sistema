
using BLL;
using Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
            
           
        }
        private Articulos LlenarClase()
        {
            Articulos articulos = new Articulos();
            articulos.ArticuloID = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            articulos.Nombre = NombretextBox.Text;
            articulos.Marca = MarcatextBox.Text;
            articulos.Fecha = FechaEntradadateTimePicker.Value = DateTime.Now;
            articulos.PrecioCompra =Convert.ToInt32( PrecioCompratextBox.Text.ToString());
            articulos.PrecioVenta =Convert.ToInt32( PrecioVentatextBox.Text.ToString());
            articulos.Ganancia = Convert.ToDecimal(GananciatextBox.Text);
            articulos.Vigencia = Convert.ToInt32(VigenciatextBox.Text);
            return articulos;
        }

        private bool Validar(int validar)
        {
            
            bool paso = false;
            int num = 0;
            if (validar == 1 && ArticuloIDnumericUpDown.Value == 0)
            {
                ArticuloerrorProvider.SetError(ArticuloIDnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            
            if (validar == 2 && NombretextBox.Text == string.Empty)
            {
                ArticuloerrorProvider.SetError(NombretextBox, "Ingrese el Nombre");
                paso = true;
            }

            if (validar == 2 && MarcatextBox.Text == string.Empty)
            {
                ArticuloerrorProvider.SetError(MarcatextBox, "Ingrese la Marca");
                paso = true;
            }

            if (validar == 3 && int.TryParse(NombretextBox.Text, out num) == true)
            {
                ArticuloerrorProvider.SetError(NombretextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            if (validar == 3 && int.TryParse(MarcatextBox.Text, out num) == true)
            {
                ArticuloerrorProvider.SetError(MarcatextBox, "Debe Digitar Caracteres");
                paso = true;
            }
            return paso;

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos = LlenarClase();
            if (Validar(2))
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }
            if (Validar(3))
            {

                MessageBox.Show("Digite un caracter no un numero");
                return;
            }
            if (ArticuloIDnumericUpDown.Value == 0)
                paso = ArticulosBLL.Guardar(articulos);

            else
            {
                var A = ArticulosBLL.Buscar(Convert.ToInt32(ArticuloIDnumericUpDown.Value));

                if (A != null)
                    paso = BLL.ArticulosBLL.Modificar(articulos);
                else
                    MessageBox.Show("No existe en la base de datos","Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            int.TryParse(ArticuloIDnumericUpDown.Text, out int id);

            if (ArticulosBLL.Eliminar(id))
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
            int.TryParse(ArticuloIDnumericUpDown.Text, out int id);
            Articulos articulos = ArticulosBLL.Buscar(id);

            if (articulos != null)
            {
                Limpiar();
                LlenaCampo(articulos);
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            ArticuloerrorProvider.Clear();
            ArticuloIDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            MarcatextBox.Clear();
            FechaEntradadateTimePicker.Value = DateTime.Now;
            PrecioCompratextBox.Text = 0.ToString();
            PrecioVentatextBox.Text = 0.ToString();
            GananciatextBox.Text = 0.ToString();
            VigenciatextBox.Text = 0.ToString();
            ArticuloerrorProvider.Clear();
        }
        private void LlenaCampo(Articulos articulos)
        {
            NombretextBox.Text = articulos.Nombre;
            MarcatextBox.Text = articulos.Marca;
            FechaEntradadateTimePicker.Value = articulos.Fecha;
            PrecioCompratextBox.Text = articulos.PrecioCompra.ToString();
            PrecioVentatextBox.Text = articulos.PrecioVenta.ToString();
            GananciatextBox.Text = articulos.Ganancia.ToString();
            VigenciatextBox.Text = articulos.Vigencia.ToString();
        }
        private void RegistroArticulos_Load(object sender, EventArgs e)
        {
            VigenciatextBox.Text = 0.ToString();
            PrecioCompratextBox.Text = 0.ToString();
            PrecioVentatextBox.Text = 0.ToString();
            GananciatextBox.Text = 0.ToString();
        }
    }
}
