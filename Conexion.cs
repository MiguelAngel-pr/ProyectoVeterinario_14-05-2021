using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //la libreria de MySql
using System.Data;  //la libreria del DataTable

namespace ProyectoVeterinario_2021
{
    class Conexion
    {
        public MySqlConnection conexion; //variable que se encarga de conectarnos al servidor MySql
        public Conexion()
        { //el constructor de la clase
          //La contraseña es "root" o "".
            conexion = new MySqlConnection("Server=127.0.0.1; Database=ejercicio_veterinario; Uid=root; Pwd=; Port=3306");
        }
        public Boolean loginInicial(String _email, String _password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM cliente WHERE email=@_email", conexion);
                //MySqlCommand consultaIdPerfil = new MySqlCommand("SELECT perfil FROM cliente WHERE email=@_email", conexion);
                consulta.Parameters.AddWithValue("@_email", _email);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                //MySqlDataReader resultado2 = consultaIdPerfil.ExecuteReader();
                if (resultado.Read())
                {
                    String passHasheada = resultado.GetString("password");
                    //String idPerfil = resultado2.GetString("perfil");
                    if (BCrypt.Net.BCrypt.Verify(_password, passHasheada)/* && idPerfil=="0"*/)
                    {
                        conexion.Close();
                        //si entra aquí es porque estan bien el usuario y la contraseña
                        return true;
                    }
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean insertaUsuario(String _DNI, String _nombre, String _apellido, String _telefono, String _email, String _direccion1, String _direccion2, String _password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO cliente (Id_cliente, DNI, nombre, apellido, telefono, email, direccion1, direccion2, password) VALUES (null, @_DNI, @_nombre, @_apellido, @_telefono, @_email, @_direccion1, @_direccion2, @_password)", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_nombre", _nombre);
                consulta.Parameters.AddWithValue("@_apellido", _apellido);
                consulta.Parameters.AddWithValue("@_telefono", _telefono);
                consulta.Parameters.AddWithValue("@_email", _email);
                consulta.Parameters.AddWithValue("@_direccion1", _direccion1);
                consulta.Parameters.AddWithValue("@_direccion2", _direccion2);
                consulta.Parameters.AddWithValue("@_password", _password);

                int resultado = consulta.ExecuteNonQuery(); //Ejecuta el insert
                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aquí es porque ha hecho bien la inserción
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
                return false;
            }
        }

        public DataTable getPerfil(String _correo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM cliente WHERE email='" + _correo + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable cliente = new DataTable(); //formato que espera el datagridview
                cliente.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return cliente;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getLista()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable clientes = new DataTable(); //formato que espera el datagridview
                clientes.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getListaPorDato(String _dato, String _busqueda)
        {
            try
            {
                DataTable cliente = new DataTable(); //formato que espera el datagridview
                conexion.Open();
                switch (_dato)
                {
                    case "DNI":
                        MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente WHERE DNI='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Nombre":
                        MySqlCommand consulta2 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente WHERE nombre='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado2 = consulta2.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado2);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Apellido":
                        MySqlCommand consulta3 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente WHERE apellido='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado3 = consulta3.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado3);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Email":
                        MySqlCommand consulta4 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente WHERE email='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado4 = consulta4.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado4);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lista Completa":
                        MySqlCommand consulta5 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente", conexion);
                        MySqlDataReader resultado5 = consulta5.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado5);  //convierte MysqlDataReader en DataTable
                        break;
                }
                conexion.Close();
                return cliente;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}