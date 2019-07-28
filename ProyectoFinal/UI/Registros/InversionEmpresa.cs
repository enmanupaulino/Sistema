using BLL;
using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class InversionEmpresa : Form
    {
        public InversionEmpresa()
        {
            InitializeComponent();
        }

        private void InversionEmpresa_Load(object sender, EventArgs e)
        {
            Inversion inversion = InversionBLL.Buscar(1);
            if(inversion==null)
            {
                inversion = new Inversion();
                InversionBLL.Guardar(new Inversion(0, 0));
            }
            Montolabel.Text = 0.ToString();
            if (inversion.Monto == 0)
                return;
            Montolabel.Text = $"${inversion.Monto.ToString()}";
            Montolabel.ForeColor = Color.Green;
            Refrescarbutton_Click(sender, e);
        }

        private void Refrescarbutton_Click(object sender, EventArgs e)
        {
            Inversion inversion = InversionBLL.Buscar(1);
            Montolabel.Text = 0.ToString();
            Montolabel.Text = $"${inversion.Monto.ToString()}";
            Montolabel.ForeColor = Color.Green;

        }
    }
}
