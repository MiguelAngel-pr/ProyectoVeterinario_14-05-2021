
namespace ProyectoVeterinario_2021
{
    partial class ventanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaLogin));
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.checkBoxContraseña = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.LightCyan;
            this.textEmail.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Silver;
            this.textEmail.Location = new System.Drawing.Point(225, 230);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(200, 21);
            this.textEmail.TabIndex = 4;
            this.textEmail.Text = "Introduzca el email";
            this.textEmail.UseWaitCursor = true;
            this.textEmail.Click += new System.EventHandler(this.textEmail_Click);
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textContraseña
            // 
            this.textContraseña.BackColor = System.Drawing.Color.LightCyan;
            this.textContraseña.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.Color.Silver;
            this.textContraseña.Location = new System.Drawing.Point(225, 267);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(200, 21);
            this.textContraseña.TabIndex = 4;
            this.textContraseña.Text = "Introduzca la contraseña";
            this.textContraseña.UseWaitCursor = true;
            this.textContraseña.Click += new System.EventHandler(this.textContraseña_Click);
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonLogin.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonLogin.Location = new System.Drawing.Point(275, 334);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(100, 35);
            this.botonLogin.TabIndex = 1;
            this.botonLogin.Text = "ACCEDER";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(225, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Aún no tienes cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkRegistro
            // 
            this.linkRegistro.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.linkRegistro.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistro.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkRegistro.Location = new System.Drawing.Point(275, 411);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.Size = new System.Drawing.Size(100, 23);
            this.linkRegistro.TabIndex = 2;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "Regístrarse";
            this.linkRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistro_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 462);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(566, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 462);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoVeterinario_2021.Properties.Resources.icons8_lock;
            this.pictureBox1.Location = new System.Drawing.Point(198, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(198, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::ProyectoVeterinario_2021.Properties.Resources.veterinario;
            this.Logo.Location = new System.Drawing.Point(262, 50);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(125, 125);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // checkBoxContraseña
            // 
            this.checkBoxContraseña.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxContraseña.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkBoxContraseña.Location = new System.Drawing.Point(431, 267);
            this.checkBoxContraseña.Name = "checkBoxContraseña";
            this.checkBoxContraseña.Size = new System.Drawing.Size(70, 21);
            this.checkBoxContraseña.TabIndex = 11;
            this.checkBoxContraseña.Text = "Mostrar";
            this.checkBoxContraseña.UseVisualStyleBackColor = true;
            this.checkBoxContraseña.CheckedChanged += new System.EventHandler(this.checkBoxContraseña_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(262, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "We❤Animals";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxContraseña;
        private System.Windows.Forms.Label label3;
    }
}

