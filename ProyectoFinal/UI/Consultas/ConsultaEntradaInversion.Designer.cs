namespace ProyectoFinal.UI.Consultas
{
    partial class ConsultaEntradaInversion
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
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.EntradaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaerrorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(38, 117);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(592, 324);
            this.ConsultadataGridView.TabIndex = 66;
            // 
            // EntradaerrorProvider
            // 
            this.EntradaerrorProvider.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CriteriotextBox);
            this.groupBox2.Controls.Add(this.TipocomboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
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
            this.Consultabutton.Location = new System.Drawing.Point(636, 39);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(108, 49);
            this.Consultabutton.TabIndex = 90;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 99);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(10, 14);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(145, 24);
            this.FechaCheckBox.TabIndex = 88;
            this.FechaCheckBox.Text = "Filtrar Por Fecha";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fecha Desde";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(124, 64);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(107, 26);
            this.HastadateTimePicker.TabIndex = 87;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(9, 64);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(102, 26);
            this.DesdedateTimePicker.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Fecha Hasta";
            // 
            // ConsultaEntradaInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultaEntradaInversion";
            this.Text = "ConsultaEntradaActivos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaerrorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider EntradaerrorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FechaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}