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
    public partial class VentanaLogin : Form
    {
        Conexion miConexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public void textEmail_Click(object sender, EventArgs e)
        {
            if (textEmail.Text.Equals("Introduzca el email"))
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.LightSeaGreen;
            }
        }

        private void textContraseña_Click(object sender, EventArgs e)
        {
            textContraseña.UseSystemPasswordChar = true;
            if (textContraseña.Text.Equals("Introduzca la contraseña"))
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.LightSeaGreen;
            }
        }
        public void botonLogin_Click(object sender, EventArgs e)
        {
            ////Esto lo uso para entrar directamente en pruebas
            //this.Hide();
            //ventanaPrincipal ventana = new ventanaPrincipal();
            //ventana.Show();

            String email = textEmail.Text; //leo lo que el usuario halla puesto.
            String password = textContraseña.Text;
            //Cuenta de prueba; email= pepito@gmail.com | contraseña= 1234
            if (miConexion.loginInicial(email, password))
            {
                String emailUsado = textEmail.Text;
                this.Hide();
                ventanaPrincipal ventana2 = new ventanaPrincipal();
                ventana2.asignaPerfil(emailUsado);
                ventana2.Show();
            }
            else //la contraseña o el usuario son incorrectos
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }
        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            VentanaRegistro ventana = new VentanaRegistro();
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
