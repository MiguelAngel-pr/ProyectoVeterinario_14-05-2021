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
    public partial class ventanaAdmin : Form
    {
        Conexion miConexion = new Conexion();
        public ventanaAdmin()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }
        private void botonVerClientes_Click(object sender, EventArgs e)
        {
            listaClientes ventana2 = new listaClientes();
            ventana2.cambio();
            ventana2.Show();
        }
        public void asignaPerfil(String correo)
        {
            DataTable perfilElegido = miConexion.getPerfil(correo);
        }

        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            ventanaRegistro ventana = new ventanaRegistro();
            ventana.cambio();
            ventana.Show();
        }
    }
}
