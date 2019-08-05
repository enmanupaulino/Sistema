namespace ProyectoFinal.UI.Registros
{
    partial class Login
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
            this.label11 = new System.Windows.Forms.Label();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpiar_button = new System.Windows.Forms.Button();
            this.IniciarSesion_button = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(38, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 33);
            this.label11.TabIndex = 84;
            this.label11.Text = "Login";
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave_textBox.Location = new System.Drawing.Point(203, 102);
            this.Clave_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.PasswordChar = '*';
            this.Clave_textBox.Size = new System.Drawing.Size(167, 26);
            this.Clave_textBox.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Clave";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_textBox.Location = new System.Drawing.Point(203, 70);
            this.Usuario_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(167, 26);
            this.Usuario_textBox.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Usuario";
            // 
            // Limpiar_button
            // 
            this.Limpiar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar_button.Location = new System.Drawing.Point(142, 139);
            this.Limpiar_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Limpiar_button.Name = "Limpiar_button";
            this.Limpiar_button.Size = new System.Drawing.Size(94, 26);
            this.Limpiar_button.TabIndex = 77;
            this.Limpiar_button.Text = "Limpiar";
            this.Limpiar_button.UseVisualStyleBackColor = true;
            this.Limpiar_button.Click += new System.EventHandler(this.Limpiar_button_Click_1);
            // 
            // IniciarSesion_button
            // 
            this.IniciarSesion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion_button.Location = new System.Drawing.Point(244, 139);
            this.IniciarSesion_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IniciarSesion_button.Name = "IniciarSesion_button";
            this.IniciarSesion_button.Size = new System.Drawing.Size(126, 26);
            this.IniciarSesion_button.TabIndex = 78;
            this.IniciarSesion_button.Text = "Iniciar Sesión";
            this.IniciarSesion_button.UseVisualStyleBackColor = true;
            this.IniciarSesion_button.Click += new System.EventHandler(this.IniciarSesion_button_Click_1);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.icono_login;
            this.pictureBox1.Location = new System.Drawing.Point(23, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 208);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpiar_button);
            this.Controls.Add(this.IniciarSesion_button);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar_button;
        private System.Windows.Forms.Button IniciarSesion_button;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}