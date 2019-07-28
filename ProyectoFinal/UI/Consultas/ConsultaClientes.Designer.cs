namespace ProyectoFinal.UI.Consultas
{
    partial class ConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteerrorProvider
            // 
            this.ClienteerrorProvider.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CriteriotextBox);
            this.groupBox2.Controls.Add(this.TipocomboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(323, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 100);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(52, 39);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(44, 20);
            this.Tipo.TabIndex = 78;
            this.Tipo.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(161, 64);
            this.CriteriotextBox.Multiline = true;
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(128, 26);
            this.CriteriotextBox.TabIndex = 80;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "ID",
            "Listar Todo"});
            this.TipocomboBox.Location = new System.Drawing.Point(6, 62);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(121, 28);
            this.TipocomboBox.TabIndex = 81;
            // 
            // Consultabutton
            // 
            this.Consultabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultabutton.Image = global::ProyectoFinal.Properties.Resources.search_32;
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(641, 28);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(108, 49);
            this.Consultabutton.TabIndex = 90;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click_1);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(51, 114);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(592, 324);
            this.ConsultadataGridView.TabIndex = 48;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ClienteerrorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}