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
            this.SuspendLayout();
            // 
            // botonVerClientes
            // 
            this.botonVerClientes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonVerClientes.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerClientes.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonVerClientes.Location = new System.Drawing.Point(30, 29);
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
            this.botonCitas.Location = new System.Drawing.Point(246, 29);
            this.botonCitas.Name = "botonCitas";
            this.botonCitas.Size = new System.Drawing.Size(156, 149);
            this.botonCitas.TabIndex = 3;
            this.botonCitas.Text = "Citas Pendientes";
            this.botonCitas.UseVisualStyleBackColor = false;
            this.botonCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // ventanaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(434, 201);
            this.Controls.Add(this.botonCitas);
            this.Controls.Add(this.botonVerClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaEmpleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVerClientes;
        private System.Windows.Forms.Button botonCitas;
    }
}