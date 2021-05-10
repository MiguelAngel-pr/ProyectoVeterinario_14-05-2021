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
    public partial class ventanaEmpleado : Form
    {
        Conexion miConexion = new Conexion();
        public ventanaEmpleado()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }

        private void botonVerClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            listaClientes ventana = new listaClientes();
            ventana.Show();
        }

        public void asignaPerfil(String correo)
        {
            DataTable perfilElegido = miConexion.getPerfil(correo);
        }
    }
}
