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
    public partial class ConsultaUsuarios : Form
    {
        List<Usuarios> usuarios = new List<Usuarios>();
        private List<Usuarios> ListaUsuarios;
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }
        Expression<Func<Usuarios, bool>> filtro = x => true;

        private void Consultabutton_Click(object sender, EventArgs e)
        {


            switch (TipocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        filtro = x => x.UsuariosId == id;

                        if (UsusariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;
                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar un Nombre!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        filtro = x => x.Nombre.Contains(CriteriotextBox.Text);


                        if (UsusariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Nombre, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }



                    break;

                case 2://Usuario

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Usuario.Equals(CriteriotextBox.Text);

                        if (UsusariosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

               
                    
                case 3://TODO
                    filtro = x => true;

                    if (UsusariosBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }

            if (TipocomboBox.SelectedItem != null)
            {
                ConsultadataGridView.DataSource = BLL.UsusariosBLL.GetList(filtro);
                CriteriotextBox.Clear();
                UsuarioerrorProvider.Clear();
            }
            ListaUsuarios = UsusariosBLL.GetList(filtro);
            ConsultadataGridView.DataSource = ListaUsuarios;
        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                UsuarioerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                UsuarioerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                UsuarioerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
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
                Report report = new Report(ListaUsuarios);
                report.ShowDialog();
            }
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {

        }

        
    }
}

