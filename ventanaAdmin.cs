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
        public ventanaAdmin()
        {
            InitializeComponent();
        }

        private void botonVerClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            listaClientes ventana = new listaClientes();
            ventana.Show();
        }
    }
}
