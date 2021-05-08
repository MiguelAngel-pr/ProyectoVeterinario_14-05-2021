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
    }
}
