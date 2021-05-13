namespace ProyectoVeterinario_2021
{
    partial class ventanaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaEmpleado));
            this.botonVerClientes = new System.Windows.Forms.Button();
            this.botonCitas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre_Apellido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVerClientes
            // 
            this.botonVerClientes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonVerClientes.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerClientes.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonVerClientes.Location = new System.Drawing.Point(33, 360);
            this.botonVerClientes.Name = "botonVerClientes";
            this.botonVerClientes.Size = new System.Drawing.Size(156, 149);
            this.botonVerClientes.TabIndex = 2;
            this.botonVerClientes.Text = "Ver Clientes";
            this.botonVerClientes.UseVisualStyleBackColor = false;
            this.botonVerClientes.Click += new System.EventHandler(this.botonVerClientes_Click);
            // 
            // botonCitas
            // 
            this.botonCitas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonCitas.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCitas.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonCitas.Location = new System.Drawing.Point(249, 360);
            this.botonCitas.Name = "botonCitas";
            this.botonCitas.Size = new System.Drawing.Size(156, 149);
            this.botonCitas.TabIndex = 3;
            this.botonCitas.Text = "Citas Pendientes";
            this.botonCitas.UseVisualStyleBackColor = false;
            this.botonCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 254);
            this.panel1.TabIndex = 4;
            // 
            // labelNombre_Apellido
            // 
            this.labelNombre_Apellido.BackColor = System.Drawing.Color.DarkCyan;
            this.labelNombre_Apellido.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre_Apellido.ForeColor = System.Drawing.Color.PowderBlue;
            this.labelNombre_Apellido.Location = new System.Drawing.Point(0, -2);
            this.labelNombre_Apellido.Name = "labelNombre_Apellido";
            this.labelNombre_Apellido.Size = new System.Drawing.Size(436, 66);
            this.labelNombre_Apellido.TabIndex = 17;
            this.labelNombre_Apellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.fotoPerfil);
            this.panel2.Location = new System.Drawing.Point(20, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 179);
            this.panel2.TabIndex = 18;
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.fotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPerfil.Image = global::ProyectoVeterinario_2021.Properties.Resources.image__1_;
            this.fotoPerfil.Location = new System.Drawing.Point(0, -4);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(180, 183);
            this.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfil.TabIndex = 2;
            this.fotoPerfil.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(110, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 238);
            this.panel3.TabIndex = 19;
            // 
            // ventanaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelNombre_Apellido);
            this.Controls.Add(this.botonCitas);
            this.Controls.Add(this.botonVerClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaEmpleado";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVerClientes;
        private System.Windows.Forms.Button botonCitas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombre_Apellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox fotoPerfil;
        private System.Windows.Forms.Panel panel3;
    }
}