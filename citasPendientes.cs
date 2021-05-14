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

namespace ProyectoVeterinario_2021
{
    public partial class citasPendientes : Form
    {
        DataTable misCitas = new DataTable();
        public citasPendientes()
        {
            InitializeComponent();
        }

        private void botonCitas_Click(object sender, EventArgs e)//Con este método se mandará la información de la barra de busqueda que el empleado halla puesto para poder mostrar la cita correspondiente.
        {
            Conexion miConexion = new Conexion();
            String busqueda = textBusqueda.Text.ToUpperInvariant();
            String dato = comboBox1.Text;
            //Metodo para quitar acentos
            if (dato == "Lugar")
            {
                String _busqueda = busqueda.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                String busquedaSinAcentos = reg.Replace(_busqueda, "");
                busquedaSinAcentos = busquedaSinAcentos.ToUpperInvariant();
                misCitas = miConexion.getListaPorDatoCita(dato, busquedaSinAcentos);
            }
            else
            {
                misCitas = miConexion.getListaPorDatoCita(dato, busqueda);
            }
            listaCitas.DataSource = misCitas;
            textBusqueda.Text = "";
        }
    }
}
