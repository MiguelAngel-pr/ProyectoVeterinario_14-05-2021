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
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.BackgroundColor = System.Drawing.Color.LightCyan;
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.Location = new System.Drawing.Point(13, 107);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(522, 249);
            this.listaUsuarios.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.LightCyan;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Silver;
            this.textEmail.Location = new System.Drawing.Point(13, 42);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(478, 38);
            this.textEmail.TabIndex = 5;
            this.textEmail.UseWaitCursor = true;
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.botonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.Color.PowderBlue;
            this.botonLogin.Location = new System.Drawing.Point(497, 42);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(38, 38);
            this.botonLogin.TabIndex = 6;
            this.botonLogin.UseVisualStyleBackColor = false;
            // 
            // listaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(547, 368);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.listaUsuarios);
            this.Name = "listaClientes";
            this.Text = "listaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button botonLogin;
    }
}