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
    public partial class ventanaEmpleado : Form
    {
        Conexion miConexion = new Conexion();
        Boolean admin = false;
        public ventanaEmpleado()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }
        public void cambio()
        {
            admin = true;
            botonVerClientes.Text = "Ver Todos los Usuarios";
            botonCitas.Text = "Registrar Empleados";
        }
        private void botonVerClientes_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                listaClientes ventana2 = new listaClientes();
                ventana2.cambio();
                ventana2.Show();
            }
            else
            {
                listaClientes ventana = new listaClientes();
                ventana.Show();
            }
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        public void asignaPerfil(String correo)
        {
            DataTable perfilElegido = miConexion.getPerfil(correo);
            labelNombre_Apellido.Text = "Bienvenido: " + perfilElegido.Rows[0]["nombre"].ToString() + " " + perfilElegido.Rows[0]["apellido"].ToString();
            fotoPerfil.Image = convierteBlobAImagen((byte[])perfilElegido.Rows[0]["foto"]);
        }

        private void botonCitas_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                ventanaRegistro ventana = new ventanaRegistro();
                ventana.cambio();
                ventana.Show();
            }
            else
            {
                citasPendientes ventana = new citasPendientes();
                ventana.Show();
            }
        }
    }
}
