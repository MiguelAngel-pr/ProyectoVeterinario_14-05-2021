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
    public partial class ventanaRegistroCitas : Form
    {
        Boolean registro = true;
        public ventanaRegistroCitas()
        {
            InitializeComponent();
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
            if(textHora.Text.Length == 2)
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
