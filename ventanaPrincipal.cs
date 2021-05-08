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
    }
}
