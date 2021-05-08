using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace ProyectoVeterinario_2021
{
    public partial class VentanaRegistro : Form
    {
        Boolean registro = true;
        public VentanaRegistro()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin ventana = new VentanaLogin();
            ventana.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }

        private void botonRegistro_Click(object sender, EventArgs e)
        {
            registro = true;
            String email = textCorreo.Text;
            if (!Validar.validarEmail(email) || textContraseña.Text != textContraseña2.Text || textDNI.Text.Length != 9 || textTelefono.Text.Length != 9 || !textDireccion1.Text.Contains("Calle") && !textDireccion1.Text.Contains("Avenida") || textCorreo.Text.Contains("@admin.com") || textCorreo.Text.Contains("@weloveanimals.com"))
            {
                registro = false;
            }
            if (registro)
            {
                String passHasheada = BCrypt.Net.BCrypt.HashPassword(textContraseña.Text, BCrypt.Net.BCrypt.GenerateSalt());

                Conexion miConexion = new Conexion();
                Boolean resultado = miConexion.insertaUsuario(textDNI.Text, textNombre.Text, textApellido.Text, textTelefono.Text, textCorreo.Text, textDireccion1.Text, textDireccion2.Text, passHasheada);
                if (resultado)
                {
                    MessageBox.Show("INSERTADO CORRECTAMENTE");
                }
                else
                {
                    MessageBox.Show("HA OCURRIDO UN ERROR INESPERADO, INTENTALO MÁS TARDE");
                }
            }
            else 
            {
                MessageBox.Show("HA OCURRIDO UN ERROR INESPERADO, INTENTALO MÁS TARDE");
            }
        }
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
