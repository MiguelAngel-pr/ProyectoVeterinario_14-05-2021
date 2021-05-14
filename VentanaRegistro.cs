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
    public partial class ventanaRegistro : Form
    {
        Boolean registro = true;
        Boolean empleado = false;//Esta variable se usará para permitirnos registrarnos como empleados
        int perfil = 0;
        public ventanaRegistro()
        {
            InitializeComponent();
        }
        public void cambio()//Este método será ejecutado desde la pestaña de admin para permitirnos registra a los empleados
        {
            empleado = true;
            label1.Text = "Registro Empleado";
            perfil = 1;
        }
        private void botonVolver_Click(object sender, EventArgs e)//Apretando a este botón volveremos atras hacia la pestaña del login o del admin
        {
            this.Hide();
            if (!empleado)
            { 
                ventanaLogin ventana = new ventanaLogin();
                ventana.Show();
            }
        }

        private void botonRegistro_Click(object sender, EventArgs e)//Este es el botón que mandará los datos que el usuario halla escrito para poder insertarlos en la BD.
        {
            registro = true;
            String email = textCorreo.Text;
            Conexion miConexion = new Conexion();
            //Con esto validaremos la información que el usuario escriba para que esta sea lo más correcta posible
            if (!Validar.validarEmail(email) || textContraseña.Text != textContraseña2.Text || textDNI.Text.Length != 9 || textTelefono.Text.Length != 9 
                || !textDireccion1.Text.Substring(0, 6).Contains("Calle ") && !textDireccion1.Text.Substring(0, 8).Contains("Avenida ") || textCorreo.Text.Contains("@admin.com") 
                || !empleado && textCorreo.Text.Contains("@weloveanimals.com") || textDNI.Text != textDNI.Text.ToUpperInvariant() || textNombre.Text.Length < 3 || textApellido.Text.Length < 3
                || textDireccion2.Text.Length > 0 && !textDireccion2.Text.Substring(0, 7).Contains("Portal ") || textDireccion2.Text.Length > 0 && !textDireccion2.Text.Substring(0, 5).Contains("Piso ")
                || textTelefono.Text.Substring(0,1) != "9" && textTelefono.Text.Substring(0, 1) != "6")
            {
                registro = false;
            }

            if (registro)//Si la validación se lleva a cabo correctamente se podrán insertar los datos.
            {
                String passHasheada = BCrypt.Net.BCrypt.HashPassword(textContraseña.Text, BCrypt.Net.BCrypt.GenerateSalt());

                //Con esto quito los acentos
                String nombre = textNombre.Text.Normalize(NormalizationForm.FormD);
                String apellido = textApellido.Text.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                String nombreSinAcentos = reg.Replace(nombre, "");
                String apellidoSinAcentos = reg.Replace(apellido, "");

                Boolean resultado = miConexion.insertaUsuario(textDNI.Text, nombreSinAcentos.ToUpperInvariant(), apellidoSinAcentos.ToUpperInvariant(), textTelefono.Text, textCorreo.Text.ToLower(), textDireccion1.Text, textDireccion2.Text, perfil, passHasheada);
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
        //Métodos usados para validar y poner subtextos
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

        private void textDNI_TextChanged(object sender, EventArgs e)
        {
            textDNI.ForeColor = Color.LightSeaGreen;
        }

        private void textDNI_Click(object sender, EventArgs e)
        {
            if (textDNI.Text.Equals("Ex: 00000000X"))
            {
                textDNI.Text = "";
            }
        }

        private void textDireccion1_TextChanged(object sender, EventArgs e)
        {
            textDireccion1.ForeColor = Color.LightSeaGreen;
        }

        private void textDireccion1_Click(object sender, EventArgs e)
        {
            if (textDireccion1.Text.Equals("Ex: Calle/Avenida XXX"))
            {
                textDireccion1.Text = "";
            }
        }

        private void textDireccion2_TextChanged(object sender, EventArgs e)
        {
            textDireccion2.ForeColor = Color.LightSeaGreen;
        }

        private void textDireccion2_Click(object sender, EventArgs e)
        {
            if (textDireccion2.Text.Equals("Ex: Portal/Piso XXX"))
            {
                textDireccion2.Text = "";
            }
        }

        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textDNI.Text.Length == 8)
            {
                Validar.soloLetras(e);
            }
            else
            {
                Validar.soloNumeros(e);
            }
        }
    }
}
