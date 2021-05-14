using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinario_2021
{
    public partial class ventanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misMascotas = new DataTable();
        DataTable misCitas = new DataTable();
        Boolean registro = true;
        public ventanaPrincipal()
        {
            InitializeComponent();
            label7.Text = "DNI:";
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit(); //cierra la aplicación completamente.
        }
        private Image convierteBlobAImagen(byte[] img)//Este método permite mostrar las imágenes por pantalla
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        public void asignaPerfil(String correo)//Este método permitirá mostrar los datos por pantalla de la cuenta con la que nos hallamos logueado
        {
            DataTable perfilElegido = miConexion.getPerfil(correo);
            textoNombre.Text = "Nombre: " + perfilElegido.Rows[0]["nombre"].ToString();
            textoApellido.Text = "Apellido: " + perfilElegido.Rows[0]["apellido"].ToString();
            textoEmail.Text = "Email: " + perfilElegido.Rows[0]["email"].ToString();
            textoTelefono.Text = "Teléfono: " + perfilElegido.Rows[0]["telefono"].ToString();
            textoDNI.Text = perfilElegido.Rows[0]["DNI"].ToString();
            fotoPerfil.Image = convierteBlobAImagen((byte[])perfilElegido.Rows[0]["foto"]);
            misMascotas = miConexion.getListaMascotas(textoDNI.Text);
            listaMascotas.DataSource = misMascotas;
            misCitas = miConexion.getListaCitas(textoDNI.Text);
            listaCitas.DataSource = misCitas;
        }

        public void botonRegistro_Click(object sender, EventArgs e)//Este es el botón que mandará los datos que el usuario halla escrito para poder insertarlos en la BD.
        {
            registro = true;
            Conexion miConexion = new Conexion();
            if (textIDMascota.Text.Length != 4 ||textMotivo.Text.Length > 250)
            {
                registro = false;
            }
            if (registro)
            {
                Boolean resultado = miConexion.insertaCita(textoDNI.Text, textIDMascota.Text, dateTimePicker1.Value.ToString("yyyyMMdd"), textHora.Text, comboBoxLugar.Text.ToUpperInvariant(), textMotivo.Text);
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

        private void botonAñadirMascota_Click(object sender, EventArgs e)//Este es el botón que mandará los datos que el usuario halla escrito para poder insertarlos en la BD.
        {
            registro = true;
            Conexion miConexion = new Conexion();
            if (textNombre_Mascota.Text.Length > 30 || textID.Text.Length != 4 || textRaza.Text.Length > 30 || textEdad.Text.Length > 2 || textPeso.Text.Length > 3
                || textAltura.Text.Length > 3)
            {
                registro = false;
            }
            String peso = textPeso.Text + comboBox1.Text;
            String altura = textAltura.Text + "cm";
            //Metodo para quitar acentos
            String nombre = textNombre_Mascota.Text.Normalize(NormalizationForm.FormD);
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            String nombreSinAcentos = reg.Replace(nombre, "");
            if (registro)
            {
                Boolean resultado = miConexion.insertaMascota(textID.Text, nombreSinAcentos.ToUpperInvariant(), comboBoxAnimal.Text, textRaza.Text, comboBoxSexo.Text, textEdad.Text, peso, altura, textoDNI.Text);
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
        //Métodos usados para validar
        private void textNombre_Mascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
           Validar.soloNumeros(e);
        }

        private void textPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
        private void textIDMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
        private void botonBusqueda_Click(object sender, EventArgs e)//Con este método se mandará los datos que el usuario halla escrito en la barra de busqueda para poder mostrar los resultados
        {
            String busqueda = busquedaMascotas.Text.ToUpperInvariant();
            String dato = comboBoxMascotas.Text;
            String dueño_Actual = textoDNI.Text;
            //Con esto quito los acentos
            if (dato == "Nombre")
            {
                String _busqueda = busqueda.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                String busquedaSinAcentos = reg.Replace(_busqueda, "");
                misMascotas = miConexion.getInfoMascota(dato, busquedaSinAcentos, dueño_Actual);
            }
            else
            {
                misMascotas = miConexion.getInfoMascota(dato, busqueda, dueño_Actual);
            }
            listaMascotas2.DataSource = misMascotas;
            busquedaMascotas.Text = "";
        }
    }
}