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
            this.botonCrearCuenta = new System.Windows.Forms.Button();
            this.botonVerClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCrearCuenta
            // 
            this.botonCrearCuenta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearCuenta.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonCrearCuenta.Location = new System.Drawing.Point(250, 151);
            this.botonCrearCuenta.Name = "botonCrearCuenta";
            this.botonCrearCuenta.Size = new System.Drawing.Size(156, 149);
            this.botonCrearCuenta.TabIndex = 5;
            this.botonCrearCuenta.Text = "Crear Cuentas Empleados";
            this.botonCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // botonVerClientes
            // 
            this.botonVerClientes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerClientes.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonVerClientes.Location = new System.Drawing.Point(27, 151);
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
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.botonCrearCuenta);
            this.Controls.Add(this.botonVerClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAdmin";
            this.Text = "ventanaAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCrearCuenta;
        private System.Windows.Forms.Button botonVerClientes;
    }
}