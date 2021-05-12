using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinario_2021
{
    public partial class ventanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        Boolean registro = true;
        public ventanaPrincipal()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        public void asignaPerfil(String correo)
        {
            DataTable perfilElegido = miConexion.getPerfil(correo);
            textoNombre.Text = "Nombre: " + perfilElegido.Rows[0]["nombre"].ToString();
            textoApellido.Text = "Apellido: " + perfilElegido.Rows[0]["apellido"].ToString();
            textoEmail.Text = "Email: " + perfilElegido.Rows[0]["email"].ToString();
            textoTelefono.Text = "Teléfono: " + perfilElegido.Rows[0]["telefono"].ToString();
            textoDNI.Text = "DNI: " + perfilElegido.Rows[0]["DNI"].ToString();
            fotoPerfil.Image = convierteBlobAImagen((byte[])perfilElegido.Rows[0]["foto"]);
        }

        private void botonCita_Click(object sender, EventArgs e)
        {
            ventanaRegistroCitas ventana = new ventanaRegistroCitas();
            ventana.Show();
            this.Hide();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            ventanaPrincipal ventana = new ventanaPrincipal();
            ventana.Show();
            this.Hide();
        }

        public void botonRegistro_Click(object sender, EventArgs e)
        {
            registro = true;
            Conexion miConexion = new Conexion();
            if (textDNI.Text.Length != 9 || textIDMascota.Text.Length != 4 || !textHora.Text.Substring(2, 3).Contains(":"))
            {
                registro = false;
            }
            if (registro)
            {
                Boolean resultado = miConexion.insertaCita(textDNI.Text, textIDMascota.Text, datosFecha.ToString(), textHora.Text, comboBoxLugar.Text, textMotivo.Text);
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

        private void textIDMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
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

        private void textHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textHora.Text.Length == 2)
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
}
