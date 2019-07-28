﻿
using BLL;
using DAL;
using Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroFacturacion : Form
    {
        private List<Articulos> ArticulosStock;

        public RegistroFacturacion()
        {
            InitializeComponent();
            LlenarComboBox();
            if (ArticulocomboBox.Items.Count > 0)
                ArticulocomboBox.SelectedIndex = 0;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        private void LlenarCampos(Facturacion facturacion)
        {
            FacturacionDetalle detalle = new FacturacionDetalle();

            Limpiar();
            FacturaIDnumericUpDown.Value = facturacion.FacturaID;
            FechadateTimePicker.Value = facturacion.Fecha;
            MontonumericUpDown.Value = facturacion.Monto;
            DevueltanumericUpDown.Value = facturacion.Devuelta;
            SubtotaltextBox.Text = facturacion.Subtotal.ToString();
            TotaltextBox.Text = facturacion.Total.ToString();
            //Cargar el detalle al Grid
            FacturaciondataGridView.DataSource = facturacion.Detalle;

            FacturaciondataGridView.Columns["ID"].Visible = false;
            FacturaciondataGridView.Columns["FacturaID"].Visible = false;
            FacturaciondataGridView.Columns["ClienteID"].Visible = false;
            FacturaciondataGridView.Columns["ArticuloID"].Visible = false;
            FacturaciondataGridView.Columns["Articulos"].Visible = false;
            ArticulocomboBox_TextChanged(null, null);
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());
            Repositorio<Cliente> repositori = new Repositorio<Cliente>(new Contexto());

            ArticulocomboBox.ValueMember = "ArticuloID";
            ArticulocomboBox.DisplayMember = "Nombre";
            ArticulocomboBox.DataSource = repositorio.GetList(c => true /*c.Vigencia > 0*/);


            ClientecomboBox.ValueMember = "ClienteID";
            ClientecomboBox.DisplayMember = "NombreCliente";
            ClientecomboBox.DataSource = repositori.GetList(c => true);
        }

        //private void ActualizarCombobox()
        //{
        //    var listadoActualizado = ArticulosStock.Where(art => art.Vigencia > 0).ToList();

        //    ArticulocomboBox.DataSource = null;

        //    if (listadoActualizado != null && listadoActualizado.Count() > 0)
        //    {
        //        ArticulocomboBox.DataSource = listadoActualizado;
        //        ArticulocomboBox.ValueMember = "ArticuloID";
        //        ArticulocomboBox.DisplayMember = "Nombre";
        //    }
        //    else
        //    {
        //        ArticulocomboBox.DataSource = null;
        //    }

        //}
        private bool Validar()
        {
            bool paso = false;

            if (MontonumericUpDown.Value == 0 && VentacomboBox.SelectedIndex == 0)
            {
                FacturacionerrorProvider.SetError(MontonumericUpDown,
                   "No debes dejar el monto Vacio ");
                paso = true;
            }
            if (FacturaciondataGridView.RowCount == 0)
            {
                FacturacionerrorProvider.SetError(FacturaciondataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            return paso;
        }

        private bool ValidarE()
        {
            bool paso = false;
            if (FacturaIDnumericUpDown.Value == 0)
            {
                FacturacionerrorProvider.SetError(FacturaIDnumericUpDown,
                   "Llene el campo");
                paso = true;
            }
            return paso;
        }
        private Facturacion LlenaClase()
        {
            Facturacion facturacion = new Facturacion();
            FacturacionDetalle detalle = new FacturacionDetalle();
            facturacion.FacturaID = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            facturacion.ClienteID = Convert.ToInt32(ClientecomboBox.SelectedValue);
            facturacion.InversionID = 1;
            facturacion.Fecha = FechadateTimePicker.Value;
            facturacion.Subtotal = Convert.ToDecimal(SubtotaltextBox.Text);
            facturacion.Total = Convert.ToDecimal(TotaltextBox.Text.ToString());
            facturacion.Abono = MontonumericUpDown.Value - DevueltanumericUpDown.Value;
            facturacion.Monto = Convert.ToDecimal(MontonumericUpDown.Value);
            facturacion.Devuelta = Convert.ToDecimal(DevueltanumericUpDown.Value);

            foreach (DataGridViewRow item in FacturaciondataGridView.Rows)
            {
                facturacion.AgregarDetalle
                    (ToInt(item.Cells["ID"].Value),
                    //facturacion.FacturaID,
                    Convert.ToInt32(item.Cells["FacturaID"].Value),
                    Convert.ToInt32(item.Cells["ClienteID"].Value),
                    Convert.ToInt32(item.Cells["ArticuloID"].Value),
                    Convert.ToString(item.Cells["Venta"].Value),
                    Convert.ToString(item.Cells["Cliente"].Value),
                    Convert.ToString(item.Cells["Articulo"].Value),
                    Convert.ToInt32(item.Cells["cantidad"].Value),
                    Convert.ToInt32(item.Cells["precio"].Value),
                    Convert.ToInt32(item.Cells["importe"].Value)
                  );
            }
            return facturacion;
        }
        public bool ValidarDetalle()
        {
            bool paso = true;
            if (Convert.ToInt32(CantidadnumericUpDown.Value) > Convert.ToInt32(CantidadDisponibleNumericUpDown.Value))
            {
                FacturacionerrorProvider.SetError(CantidadnumericUpDown, "No hay cantidad disponible");
                paso = false;
            }
            return paso;
        }
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (!ValidarDetalle())
                return;
            List<FacturacionDetalle> detalle = new List<FacturacionDetalle>();
            if (FacturaciondataGridView.DataSource != null)
            {
                detalle = (List<FacturacionDetalle>)FacturaciondataGridView.DataSource;
            }
            if (string.IsNullOrEmpty(ImportetextBox.Text))
            {
                MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
                    new FacturacionDetalle(iD: 0,
                    facturaID: (int)Convert.ToInt32(FacturaIDnumericUpDown.Value),
                    venta: (string)VentacomboBox.Text,
                    clienteID: (int)ClientecomboBox.SelectedValue,
                       cliente: (string)ClientecomboBox.Text,
                            articuloID: (int)ArticulocomboBox.SelectedValue,
                            articulo: (string)ArticulocomboBox.Text,

                        cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                        precio: Convert.ToInt32(PrecionumericUpDown.Value),
                        importe: Convert.ToInt32(ImportetextBox.Text)
                    ));


                FacturaciondataGridView.DataSource = null;
                FacturaciondataGridView.DataSource = detalle;

                //this.ArticulosStock.Find(art => art.ArticuloID ==
                //    (int)ArticulocomboBox.SelectedValue).Vigencia -= Convert.ToInt32(CantidadnumericUpDown.Value);

                //ActualizarCombobox();

                if (VentacomboBox.SelectedIndex == 0)
                {

                    FacturaciondataGridView.DataSource = null;
                    FacturaciondataGridView.DataSource = detalle;

                    FacturaciondataGridView.Columns["Cliente"].Visible = false;
                    //FacturaciondataGridView.Columns["Monto"].Visible = true;
                    //FacturaciondataGridView.Columns["Devuelta"].Visible = true;
                }
                else
                if (VentacomboBox.SelectedIndex == 1)
                {
                    FacturaciondataGridView.Columns["Cliente"].Visible = true;
                    //FacturaciondataGridView.Columns["Monto"].Visible = false;
                    //FacturaciondataGridView.Columns["Devuelta"].Visible = false;
                }


                //FacturaciondataGridView.Columns["ID"].Visible = false;
                FacturaciondataGridView.Columns["FacturaID"].Visible = false;
                FacturaciondataGridView.Columns["ClienteID"].Visible = false;
                FacturaciondataGridView.Columns["ArticuloID"].Visible = false;
                FacturaciondataGridView.Columns["Articulos"].Visible = false;
                decimal subtotal = 0;
                decimal total = 0;
                foreach (var item in detalle)
                {
                    subtotal += item.Importe;
                }
                SubtotaltextBox.Text = (subtotal * Convert.ToDecimal(0.82)).ToString();
                total += subtotal;
                TotaltextBox.Text = total.ToString();
            }
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            decimal precio = Convert.ToInt32(PrecionumericUpDown.Value);
            ImportetextBox.Text = FacturacionBLL.CalcularImporte(precio, cantidad).ToString();
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            int precio = Convert.ToInt32(PrecionumericUpDown.Value);


            ImportetextBox.Text = FacturacionBLL.CalcularImporte(precio, cantidad).ToString();
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (FacturaciondataGridView.Rows.Count > 0
              && FacturaciondataGridView.CurrentRow != null)
            {

                List<FacturacionDetalle> detalle = (List<FacturacionDetalle>)FacturaciondataGridView.DataSource;



                detalle.RemoveAt(FacturaciondataGridView.CurrentRow.Index);


                int subtotal = 0;
                int total = 0;

                foreach (var item in detalle)
                {
                    subtotal += item.Importe;
                }

                SubtotaltextBox.Text = subtotal.ToString();

                total += Convert.ToInt32(SubtotaltextBox.Text);

                TotaltextBox.Text = total.ToString();

                FacturaciondataGridView.DataSource = null;
                FacturaciondataGridView.DataSource = detalle;


                //this.ArticulosStock.Find(art => art.ArticuloID ==
                //    CantidadnumericUpDown.Value).ArticuloID+= A ;

                //ActualizarCombobox();


                //FacturaciondataGridView.Columns["ID"].Visible = false;
                FacturaciondataGridView.Columns["FacturaID"].Visible = false;
                FacturaciondataGridView.Columns["ClienteID"].Visible = false;
                FacturaciondataGridView.Columns["ArticuloID"].Visible = false;
                FacturaciondataGridView.Columns["Articulos"].Visible = false;

            }
        }

        private void DevueltatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MontonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(TotaltextBox.Text);
            decimal monto = Convert.ToDecimal(MontonumericUpDown.Value);

            /*if (monto < total)
                MessageBox.Show("le falta dinero para pagar el ariculo", "Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (monto >= total)*/
            DevueltanumericUpDown.Value = FacturacionBLL.CalcularDevuelta(monto, total);


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = LlenaClase();
            Contexto contexto = new Contexto();
            Inversion inversion = new Inversion();
            Cliente cliente = new Cliente();

            Facturacion Facturacion = new Facturacion();
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (var item in BLL.InversionBLL.GetList(x => x.InversionID == 1))
                {

                    if (item.Monto < Convert.ToDecimal(TotaltextBox.Text))
                    {
                        MessageBox.Show("Mi empresa no contien Esa Cantidad de dinero ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (VentacomboBox.SelectedIndex == 0)
            {
                inversion.Monto += Facturacion.Total;
            }
            else
            {
                Facturacion.Total += cliente.Total;
            }
            if (FacturaIDnumericUpDown.Value == 0)
            {
                if (VentacomboBox.SelectedIndex == 1)
                {
                    MontonumericUpDown.Enabled = false;
                    DevueltanumericUpDown.Enabled = false;
                }
                Paso = BLL.FacturacionBLL.Guardar(facturacion);
                FacturacionerrorProvider.Clear();
            }
            else
            {
                var M = BLL.FacturacionBLL.Buscar(Convert.ToInt32(FacturaIDnumericUpDown.Value));

                if (M != null)
                {
                    Paso = BLL.FacturacionBLL.Modificar(facturacion);
                }
                FacturacionerrorProvider.Clear();
            }
            if (Paso)
            {
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarE())
            {
                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);
                if (BLL.FacturacionBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            FacturaIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Text = 0.ToString();
            CantidadDisponibleNumericUpDown.Value = 0;
            
            SubtotaltextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            FacturacionerrorProvider.Clear();
            FacturaciondataGridView.DataSource = null;
            MontonumericUpDown.Value = 0;
            DevueltanumericUpDown.Value = 0;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            Facturacion facturacion = BLL.FacturacionBLL.Buscar(id);

            if (facturacion != null)
            {
                Limpiar();
                LlenarCampos(facturacion);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void VentacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VentacomboBox.SelectedIndex == 0)
            {
                MontonumericUpDown.Enabled = true;
                DevueltanumericUpDown.Enabled = true;
                ClientecomboBox.Enabled = false;
            }
            else
            {
                ClientecomboBox.Enabled = true;
                MontonumericUpDown.Enabled = false;
                DevueltanumericUpDown.Enabled = false;

            }
        }
        private void RegistroFacturacion_Load(object sender, EventArgs e)
        {
            TotaltextBox.Text = 0.ToString();
            SubtotaltextBox.Text = 0.ToString();
        }
        private void ArticulocomboBox_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticulocomboBox.SelectedValue);
            Articulos articulo = BLL.ArticulosBLL.Buscar(id);
            PrecionumericUpDown.Value = articulo.PrecioVenta;
            CantidadDisponibleNumericUpDown.Value = articulo.Vigencia;
        }
        /*  private void button1_Click(object sender, EventArgs e)
{
List<Facturacion> list = BLL.FacturacionBLL.GetList(X => true);

List<Facturacion> nuevo = new List<Facturacion>();

nuevo.Add(list.Last());

ReporteFacturacion abrir = new ReporteFacturacion(nuevo);
abrir.Show();
}*/
    }
}