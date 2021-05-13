
namespace ProyectoVeterinario_2021
{
    partial class citasPendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listaCitas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonCitas = new System.Windows.Forms.Button();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaCitas
            // 
            this.listaCitas.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaCitas.DefaultCellStyle = dataGridViewCellStyle11;
            this.listaCitas.Location = new System.Drawing.Point(12, 128);
            this.listaCitas.Name = "listaCitas";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.listaCitas.Size = new System.Drawing.Size(560, 197);
            this.listaCitas.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 65);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Citas Pendientes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            "DNI",
            "ID Mascota",
            "Lugar",
            "Lista Completa"});
            this.comboBox1.Location = new System.Drawing.Point(379, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 36);
            this.comboBox1.TabIndex = 26;
            // 
            // botonCitas
            // 
            this.botonCitas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCitas.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonCitas.Location = new System.Drawing.Point(335, 84);
            this.botonCitas.Name = "botonCitas";
            this.botonCitas.Size = new System.Drawing.Size(38, 37);
            this.botonCitas.TabIndex = 24;
            this.botonCitas.Text = "<";
            this.botonCitas.UseVisualStyleBackColor = false;
            this.botonCitas.Click += new System.EventHandler(this.botonCitas_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.BackColor = System.Drawing.Color.LightCyan;
            this.textBusqueda.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBusqueda.Location = new System.Drawing.Point(12, 85);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(361, 37);
            this.textBusqueda.TabIndex = 23;
            this.textBusqueda.UseWaitCursor = true;
            // 
            // citasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(584, 337);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonCitas);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaCitas);
            this.Name = "citasPendientes";
            this.Text = "citasPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listaCitas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonCitas;
        private System.Windows.Forms.TextBox textBusqueda;
    }
}