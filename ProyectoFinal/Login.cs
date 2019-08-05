﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Usuario_textBox.Text))
            {
             ErrorProvider.SetError(Usuario_textBox, "El campo Usuario no puede estar vacío");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Clave_textBox.Text))
            {
             ErrorProvider.SetError(Clave_textBox, "El campo Clave no puede estar vacío");
                paso = false;
            }

            return paso;
        }

        private bool ValidarLogin()
        {
            bool paso = false;

            if (Usuario_textBox.Text == "Admin" && Clave_textBox.Text == "12345")
            {
                paso = true;
            }

            return paso;
        }
        public int IdUsuario;
        private void IniciarSesion_button_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (!ValidarLogin())
            {
                MessageBox.Show("Usuario No Valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm main = new MainForm();
            Hide();
            main.ShowDialog();
            Dispose();

        }

        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Usuario_textBox.Text = string.Empty;
            Clave_textBox.Text = string.Empty;
        }

        private void IniciarSesion_button_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (!ValidarLogin())
            {
                MessageBox.Show("Usuario No Valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MainForm main = new MainForm();
            Hide();
            main.ShowDialog();
            Dispose();
        }

        private void Limpiar_button_Click_1(object sender, EventArgs e)
        {
            Usuario_textBox.Text = string.Empty;
            Clave_textBox.Text = string.Empty;
        }
    }
}
