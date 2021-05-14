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
        public Boolean loginInicial(String _email, String _password)//Con este método se comprobará que el email y la contraseña sean correctas,
        {                                                           //y si lo son se permitirá el acceso a esa cuenta.
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM cliente WHERE email=@_email", conexion);
                //MySqlCommand consultaIdPerfil = new MySqlCommand("SELECT perfil FROM cliente WHERE email=@_email", conexion);
                consulta.Parameters.AddWithValue("@_email", _email);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    String passHasheada = resultado.GetString("password");
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

        public Boolean insertaUsuario(String _DNI, String _nombre, String _apellido, String _telefono, String _email, String _direccion1, String _direccion2, int _perfil, String _password)
        //Este es el método con el cual se insertarán los datos del usuario registrado en la base de datos.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO cliente (Id_cliente, DNI, nombre, apellido, telefono, email, direccion1, direccion2, perfil, password) VALUES (null, @_DNI, @_nombre, @_apellido, @_telefono, @_email, @_direccion1, @_direccion2, @_perfil, @_password)", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_nombre", _nombre);
                consulta.Parameters.AddWithValue("@_apellido", _apellido);
                consulta.Parameters.AddWithValue("@_telefono", _telefono);
                consulta.Parameters.AddWithValue("@_email", _email);
                consulta.Parameters.AddWithValue("@_direccion1", _direccion1);
                consulta.Parameters.AddWithValue("@_direccion2", _direccion2);
                consulta.Parameters.AddWithValue("@_perfil", _perfil);
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

        public Boolean insertaCita(String _id_dueño, String _id_mascota, String _fecha, String _hora, String _lugar, String _motivo)
        //Este es el método con el cual se insertarán los datos de la cita en la base de datos.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO citas (id_cita, id_dueño, id_mascota, fecha, hora, lugar, motivo) VALUES (null, @_id_dueño, @_id_mascota, @_fecha, @_hora, @_lugar, @_motivo)", conexion);
                consulta.Parameters.AddWithValue("@_id_dueño", _id_dueño);
                consulta.Parameters.AddWithValue("@_id_mascota", _id_mascota);
                consulta.Parameters.AddWithValue("@_fecha", _fecha);
                consulta.Parameters.AddWithValue("@_hora", _hora);
                consulta.Parameters.AddWithValue("@_lugar", _lugar);
                consulta.Parameters.AddWithValue("@_motivo", _motivo);

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

        public Boolean insertaMascota(String _id_mascota, String _nombre, String _animal, String _raza, String _sexo, String _edad, String _peso, String _altura, String _id_dueño)
        //Este es el método con el cual se insertarán los datos de la mascota registrado en la base de datos.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO animal (cod_animal, nombre, animal, raza, sexo, edad, peso, altura, dueño) VALUES (@_id_mascota, @_nombre, @_animal, @_raza, @_sexo, @_edad, @_peso, @_altura, @_id_dueño)", conexion);
                consulta.Parameters.AddWithValue("@_id_mascota", _id_mascota);
                consulta.Parameters.AddWithValue("@_nombre", _nombre);
                consulta.Parameters.AddWithValue("@_animal", _animal);
                consulta.Parameters.AddWithValue("@_raza", _raza);
                consulta.Parameters.AddWithValue("@_sexo", _sexo);
                consulta.Parameters.AddWithValue("@_edad", _edad);
                consulta.Parameters.AddWithValue("@_peso", _peso);
                consulta.Parameters.AddWithValue("@_altura", _altura);
                consulta.Parameters.AddWithValue("@_id_dueño", _id_dueño);

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
        //Con este método se seleccionará el perfil usado al iniciar sesión para usar la información que queramos de este.
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

        public DataTable getListaUsuarios()
        //Con este método obtendremos una lista de todos los clientes y los empleados.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2", conexion);
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

        public DataTable getListaClientes()
        //Con este método obtendremos una lista de todos los clientes
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0", conexion);
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

        public DataTable getListaMascotas(String _IdDueño)
        //Con este método obtendremos una lista de todas las mascotas de un cliente.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT cod_animal, nombre, animal, dueño FROM animal where dueño='" + _IdDueño + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable mascotas = new DataTable(); //formato que espera el datagridview
                mascotas.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getListaCitas(String _IdDueño)
        //Con este método obtendremos una lista de todas las citas de un cliente.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT id_mascota, fecha, hora, lugar FROM citas where id_dueño='" + _IdDueño + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable citas = new DataTable(); //formato que espera el datagridview
                citas.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return citas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getListaPorDatoUsuario(String _dato, String _busqueda)
        //Este método se usará para buscar a cada cliente o empleado y mostrar una lista con su información
        {
            try
            {
                DataTable cliente = new DataTable(); //formato que espera el datagridview
                conexion.Open();
                switch (_dato)
                {
                    case "DNI":
                        MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2 and DNI='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Nombre":
                        MySqlCommand consulta2 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2 and nombre='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado2 = consulta2.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado2);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Apellido":
                        MySqlCommand consulta3 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2 and apellido='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado3 = consulta3.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado3);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Email":
                        MySqlCommand consulta4 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2 and email='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado4 = consulta4.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado4);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lista Completa":
                        MySqlCommand consulta5 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where not perfil = 2", conexion);
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

        public DataTable getListaPorDatoCliente(String _dato, String _busqueda)
        //Este método se usará para buscar a cada cliente y mostrar una lista con su información
        {
            try
            {
                DataTable cliente = new DataTable(); //formato que espera el datagridview
                conexion.Open();
                switch (_dato)
                {
                    case "DNI":
                        MySqlCommand consulta = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0 and DNI='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Nombre":
                        MySqlCommand consulta2 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0 and nombre='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado2 = consulta2.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado2);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Apellido":
                        MySqlCommand consulta3 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0 and apellido='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado3 = consulta3.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado3);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Email":
                        MySqlCommand consulta4 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0 and email='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado4 = consulta4.ExecuteReader(); //guardo el resultado de la query
                        cliente.Load(resultado4);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lista Completa":
                        MySqlCommand consulta5 = new MySqlCommand("SELECT DNI, nombre, apellido, telefono, email FROM cliente where perfil = 0", conexion);
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

        public DataTable getListaPorDatoCita(String _dato, String _busqueda)
        //Este método lo usará cada cliente para buscar información sobre sus citas y mostrar una lista con su información
        {
            try
            {
                DataTable citas = new DataTable(); //formato que espera el datagridview
                conexion.Open();
                switch (_dato)
                {
                    case "DNI":
                        MySqlCommand consulta = new MySqlCommand("SELECT * FROM citas where id_dueño='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                        citas.Load(resultado);  //convierte MysqlDataReader en DataTable
                        break;
                    case "ID Mascota":
                        MySqlCommand consulta2 = new MySqlCommand("SELECT * FROM citas where id_mascota='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado2 = consulta2.ExecuteReader(); //guardo el resultado de la query
                        citas.Load(resultado2);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lugar":
                        MySqlCommand consulta3 = new MySqlCommand("SELECT * FROM citas where lugar='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado3 = consulta3.ExecuteReader(); //guardo el resultado de la query
                        citas.Load(resultado3);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lista Completa":
                        MySqlCommand consulta5 = new MySqlCommand("SELECT * FROM citas", conexion);
                        MySqlDataReader resultado5 = consulta5.ExecuteReader(); //guardo el resultado de la query
                        citas.Load(resultado5);  //convierte MysqlDataReader en DataTable
                        break;
                }
                conexion.Close();
                return citas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getInfoMascota(String _dato, String _busqueda, String _dueño)
        //Este método se usará para buscar a cada mascota y mostrar una lista con su información
        {
            try
            {
                DataTable animal = new DataTable(); //formato que espera el datagridview
                conexion.Open();
                switch (_dato)
                {
                    case "ID Mascota":
                        MySqlCommand consulta = new MySqlCommand("SELECT * FROM animal where dueño ='" + _dueño + "' and cod_animal='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                        animal.Load(resultado);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Nombre":
                        MySqlCommand consulta2 = new MySqlCommand("SELECT * FROM animal where dueño ='" + _dueño + "' and nombre='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado2 = consulta2.ExecuteReader(); //guardo el resultado de la query
                        animal.Load(resultado2);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Raza":
                        MySqlCommand consulta3 = new MySqlCommand("SELECT * FROM animal where dueño ='" + _dueño + "' and raza='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado3 = consulta3.ExecuteReader(); //guardo el resultado de la query
                        animal.Load(resultado3);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Animal":
                        MySqlCommand consulta4 = new MySqlCommand("SELECT * FROM animal where dueño ='" + _dueño + "' and animal='" + _busqueda + "'", conexion);
                        MySqlDataReader resultado4 = consulta4.ExecuteReader(); //guardo el resultado de la query
                        animal.Load(resultado4);  //convierte MysqlDataReader en DataTable
                        break;
                    case "Lista Completa":
                        MySqlCommand consulta5 = new MySqlCommand("SELECT * FROM animal where dueño ='" + _dueño + "'", conexion);
                        MySqlDataReader resultado5 = consulta5.ExecuteReader(); //guardo el resultado de la query
                        animal.Load(resultado5);  //convierte MysqlDataReader en DataTable
                        break;
                }
                conexion.Close();
                return animal;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}