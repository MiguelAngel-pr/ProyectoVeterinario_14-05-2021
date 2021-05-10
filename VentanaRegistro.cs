using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace ProyectoVeterinario_2021
{
    public partial class VentanaRegistro : Form
    {
        Boolean registro = true;
        Boolean empleado = false;
        public VentanaRegistro()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }
        public void cambio()
        {
            empleado = true;
            label1.Text = "Registro Empleado";
        }
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin ventana = new VentanaLogin();
            ventana.Show();
        }

        private void botonRegistro_Click(object sender, EventArgs e)
        {
            registro = true;
            String email = textCorreo.Text;
            Conexion miConexion = new Conexion();
            if (!Validar.validarEmail(email) || textContraseña.Text != textContraseña2.Text || textDNI.Text.Length != 9 || textTelefono.Text.Length != 9 
                || !textDireccion1.Text.Contains("Calle ") && !textDireccion1.Text.Contains("Avenida ") || textCorreo.Text.Contains("@admin.com") 
                || !empleado && textCorreo.Text.Contains("@weloveanimals.com") || textDNI.Text != textDNI.Text.ToUpperInvariant() || textNombre.Text.Length < 3 || textApellido.Text.Length < 3)
            {
                registro = false;
            }

            if (registro)
            {
                String passHasheada = BCrypt.Net.BCrypt.HashPassword(textContraseña.Text, BCrypt.Net.BCrypt.GenerateSalt());

                //Metodo para quitar acentos
                String nombre = textNombre.Text.Normalize(NormalizationForm.FormD);
                String apellido = textApellido.Text.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                String nombreSinAcentos = reg.Replace(nombre, "");
                String apellidoSinAcentos = reg.Replace(apellido, "");

                Boolean resultado = miConexion.insertaUsuario(textDNI.Text, nombreSinAcentos.ToUpperInvariant(), apellidoSinAcentos.ToUpperInvariant(), textTelefono.Text, textCorreo.Text, textDireccion1.Text, textDireccion2.Text, passHasheada);
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
