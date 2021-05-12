﻿using System;
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
        Boolean empleado = false;
        int perfil = 0;
        public ventanaRegistro()
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
            perfil = 1;
        }
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaLogin ventana = new ventanaLogin();
            ventana.Show();
        }

        private void botonRegistro_Click(object sender, EventArgs e)
        {
            registro = true;
            String email = textCorreo.Text;
            Conexion miConexion = new Conexion();
            if (!Validar.validarEmail(email) || textContraseña.Text != textContraseña2.Text || textDNI.Text.Length != 9 || textTelefono.Text.Length != 9 
                || !textDireccion1.Text.Substring(0, 6).Contains("Calle ") && !textDireccion1.Text.Substring(0, 8).Contains("Avenida ") || textCorreo.Text.Contains("@admin.com") 
                || !empleado && textCorreo.Text.Contains("@weloveanimals.com") || textDNI.Text != textDNI.Text.ToUpperInvariant() || textNombre.Text.Length < 3 || textApellido.Text.Length < 3
                || textDireccion2.Text.Length > 0 && !textDireccion2.Text.Substring(0, 7).Contains("Portal ") || textDireccion2.Text.Length > 0 && !textDireccion2.Text.Substring(0, 5).Contains("Piso "))
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

                Boolean resultado = miConexion.insertaUsuario(textDNI.Text, nombreSinAcentos.ToUpperInvariant(), apellidoSinAcentos.ToUpperInvariant(), textTelefono.Text, textCorreo.Text, textDireccion1.Text, textDireccion2.Text, perfil, passHasheada);
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
