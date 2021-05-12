using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinario_2021
{
    public partial class ventanaLogin : Form
    {
        Conexion miConexion = new Conexion();
        public ventanaLogin()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }

        public void textEmail_Click(object sender, EventArgs e)
        {
            if (textEmail.Text.Equals("Introduzca el email"))
            {
                textEmail.Text = "";
            }
        }
        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            textEmail.ForeColor = Color.LightSeaGreen;
        }

        private void textContraseña_Click(object sender, EventArgs e)
        {
            textContraseña.UseSystemPasswordChar = true;
            if (textContraseña.Text.Equals("Introduzca la contraseña"))
            {
                textContraseña.Text = "";
            }
        }
        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            textContraseña.ForeColor = Color.LightSeaGreen;
        }
        public void botonLogin_Click(object sender, EventArgs e)
        {
            String email = textEmail.Text; //leo lo que el usuario halla puesto.
            String password = textContraseña.Text;
            //Cuenta de prueba; email= pepito@gmail.com | contraseña= 1234
            if (miConexion.loginInicial(email, password))
            {
                String emailUsado = textEmail.Text;
                this.Hide();
                if (emailUsado.Contains("@admin.com"))//Contraseña: 0101
                {
                    ventanaAdmin ventana0 = new ventanaAdmin();
                    ventana0.asignaPerfil(emailUsado);
                    ventana0.Show();
                }
                else if (emailUsado.Contains("@weloveanimals.com"))
                {
                    ventanaEmpleado ventana1 = new ventanaEmpleado();
                    ventana1.asignaPerfil(emailUsado);
                    ventana1.Show();
                }
                else
                {
                    ventanaPrincipal ventana2 = new ventanaPrincipal();
                    ventana2.asignaPerfil(emailUsado);
                    ventana2.Show();
                }
            }
            else //la contraseña o el usuario son incorrectos
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }
        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ventanaRegistro ventana = new ventanaRegistro();
            ventana.Show();
        }

        private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            textContraseña.UseSystemPasswordChar = true;
            if (checkBoxContraseña.Checked)
            {
                textContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
