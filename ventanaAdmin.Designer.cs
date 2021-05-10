namespace ProyectoVeterinario_2021
{
    partial class ventanaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAdmin));
            this.botonCrearCuenta = new System.Windows.Forms.Button();
            this.botonVerClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCrearCuenta
            // 
            this.botonCrearCuenta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonCrearCuenta.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCuenta.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonCrearCuenta.Location = new System.Drawing.Point(250, 26);
            this.botonCrearCuenta.Name = "botonCrearCuenta";
            this.botonCrearCuenta.Size = new System.Drawing.Size(156, 149);
            this.botonCrearCuenta.TabIndex = 5;
            this.botonCrearCuenta.Text = "Registrar Empleados";
            this.botonCrearCuenta.UseVisualStyleBackColor = false;
            this.botonCrearCuenta.Click += new System.EventHandler(this.botonCrearCuenta_Click);
            // 
            // botonVerClientes
            // 
            this.botonVerClientes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonVerClientes.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerClientes.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonVerClientes.Location = new System.Drawing.Point(27, 26);
            this.botonVerClientes.Name = "botonVerClientes";
            this.botonVerClientes.Size = new System.Drawing.Size(156, 149);
            this.botonVerClientes.TabIndex = 4;
            this.botonVerClientes.Text = "Ver Todos los Usuarios";
            this.botonVerClientes.UseVisualStyleBackColor = false;
            this.botonVerClientes.Click += new System.EventHandler(this.botonVerClientes_Click);
            // 
            // ventanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(434, 201);
            this.Controls.Add(this.botonCrearCuenta);
            this.Controls.Add(this.botonVerClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCrearCuenta;
        private System.Windows.Forms.Button botonVerClientes;
    }
}