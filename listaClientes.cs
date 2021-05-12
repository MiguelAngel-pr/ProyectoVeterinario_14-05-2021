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
    public partial class listaClientes : Form
    {
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado
                                              //para conectarnos a la BBDD MySql

        DataTable misClientes = new DataTable(); //variable que almacena el array de dos 
                                                 //dimensiones resultado de la consulta
        Boolean admin = false;
        public listaClientes()
        {
            InitializeComponent();
            if (admin == false)
            {
                misClientes = miConexion.getListaClientes();
            }
            else
            {
                misClientes = miConexion.getListaUsuarios();
            }
            listaUsuarios.DataSource = misClientes;
        }
        public void cambio()
        {
            admin = true;
            label3.Text = "Buscador de Usuarios";
            misClientes = miConexion.getListaUsuarios();
            listaUsuarios.DataSource = misClientes;
        }
        private void botonBusqueda_Click(object sender, EventArgs e)
        {
            String busqueda = textBusqueda.Text.ToUpperInvariant();
            String dato = comboBox1.Text;
            //Metodo para quitar acentos
            if (dato == "Nombre" || dato == "Apellido")
            {
                String _busqueda = busqueda.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                String busquedaSinAcentos = reg.Replace(_busqueda, "");
                if (!admin)
                {
                    misClientes = miConexion.getListaPorDatoCliente(dato, busquedaSinAcentos);
                }
                else
                {
                    misClientes = miConexion.getListaPorDatoUsuario(dato, busquedaSinAcentos);
                }
            }
            else
            {
                if (!admin)
                {
                    misClientes = miConexion.getListaPorDatoCliente(dato, busqueda);
                }
                else
                {
                    misClientes = miConexion.getListaPorDatoUsuario(dato, busqueda);
                }
            }
            listaUsuarios.DataSource = misClientes;
            textBusqueda.Text = "";
        }
    }
}
