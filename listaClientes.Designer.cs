namespace ProyectoVeterinario_2021
{
    partial class listaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaClientes));
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonBusqueda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.BackgroundColor = System.Drawing.Color.LightCyan;
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.GridColor = System.Drawing.Color.LightSeaGreen;
            this.listaUsuarios.Location = new System.Drawing.Point(13, 108);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(534, 251);
            this.listaUsuarios.TabIndex = 0;
            // 
            // textBusqueda
            // 
            this.textBusqueda.BackColor = System.Drawing.Color.LightCyan;
            this.textBusqueda.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBusqueda.Location = new System.Drawing.Point(13, 42);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(337, 37);
            this.textBusqueda.TabIndex = 5;
            this.textBusqueda.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Email",
            "DNI",
            "Lista Completa"});
            this.comboBox1.Location = new System.Drawing.Point(398, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 36);
            this.comboBox1.TabIndex = 7;
            // 
            // botonBusqueda
            // 
            this.botonBusqueda.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBusqueda.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonBusqueda.Location = new System.Drawing.Point(344, 41);
            this.botonBusqueda.Name = "botonBusqueda";
            this.botonBusqueda.Size = new System.Drawing.Size(38, 39);
            this.botonBusqueda.TabIndex = 8;
            this.botonBusqueda.Text = "<";
            this.botonBusqueda.UseVisualStyleBackColor = false;
            this.botonBusqueda.Click += new System.EventHandler(this.botonBusqueda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 101);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(23, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Buscador de Clientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(559, 371);
            this.Controls.Add(this.botonBusqueda);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}