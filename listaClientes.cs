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
    public partial class listaClientes : Form
    {
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado
                                              //para conectarnos a la BBDD MySql

        DataTable misClientes = new DataTable(); //variable que almacena el array de dos 
                                                 //dimensiones resultado de la consulta
        public listaClientes()
        {
            InitializeComponent();
            misClientes = miConexion.getLista();
            listaUsuarios.DataSource = misClientes;
        }
    }
}
