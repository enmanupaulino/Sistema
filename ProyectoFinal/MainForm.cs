using ProyectoFinal.UI.Consultas;
using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulos A = new RegistroArticulos
            {
                MdiParent = this
            };
            A.Show();
        }

        private void entradaArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntradaArticulos registroEntradaArticulos = new RegistroEntradaArticulos
            {
                MdiParent = this
            };
            registroEntradaArticulos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente registroCliente = new RegistroCliente
            {
                MdiParent = this
            };
            registroCliente.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroFacturacion registroFacturacion = new RegistroFacturacion
            {
                MdiParent = this
            };
            registroFacturacion.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaArticulos consulta = new ConsultaArticulos
            {
                MdiParent = this
            };
            consulta.Show();
        }

        private void entradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradaArticulos consultaEntrada = new ConsultaEntradaArticulos
            {
                MdiParent = this
            };
            consultaEntrada.Show();
        }

    
        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes clientes = new ConsultaClientes
            {
                MdiParent = this
            };
            clientes.Show();
        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFacturacion facturacion = new ConsultaFacturacion
            {
                MdiParent = this
            };
            facturacion.Show();
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InversionEmpresa inversion = new InversionEmpresa
            {
                MdiParent = this
            };
            inversion.Show();
        }

        private void entradaDeInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntradaInversion registro = new RegistroEntradaInversion
            {
                MdiParent = this
            };
            registro.Show();
        }

        private void cobroAlClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPagoCliente registroPago = new RegistroPagoCliente
            {
                MdiParent = this
            };
            registroPago.Show();

        }

        private void entradaDeInversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEntradaInversion inversion = new ConsultaEntradaInversion
            {
                MdiParent = this
            };
            inversion.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaPago pago = new ConsultaPago
            {
                MdiParent = this
            };
            pago.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios registro = new RegistroDeUsuarios
            {
                MdiParent = this
            };
            registro.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios usuarios = new ConsultaUsuarios
            {
                MdiParent = this
            };
            usuarios.Show();
        }
    }
}
