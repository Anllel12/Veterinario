using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
 * Autor: Angel Esquins
 * 
 * En esta clase bservamos todas los metodos que utilizamos para conectarnos con la base de datos.
 * 
 */

namespace Veterinario
{
    class Connection
    {
        public MySqlConnection connection;

        public Connection()
        {
            try
            {
                connection = new MySqlConnection("Server=127.0.0.1; Database=veterinario; Uid=root; Pwd=; Port=3306");//se conecta con la base de datos
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getUserPassword()//obtiene el usuario y contraseña
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT usuario, contraseña FROM empleado", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable employee = new DataTable();
                employee.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                return employee;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getAllAnimals()//obtiene todos los animales
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM animales ORDER BY codigo DESC", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable animals = new DataTable();
                animals.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                return animals;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getAllClients()//obtiene todos los clientes
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM cliente", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable client = new DataTable();
                client.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                return client;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getAllEmployee()//obtiene todos los clientes
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM empleado", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable client = new DataTable();
                client.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                return client;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable insertAnimal(String values)//inserta los datos de los animales en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT animales VALUES ("+ values + "');", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable animals = new DataTable();
                animals.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                Console.WriteLine(values);
                return animals;
                
            }
            catch (MySqlException e)
            {
                Console.WriteLine(values);

                Clients window = new Clients();

                window.Show();
                window.errorAñadir.Text = "Añada primero el dueño del animal o revise su dni.";
                
                throw e;                
            }
        }

        public DataTable insertClient(String values)//inserta los datos de los clientes en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT cliente VALUES ('" + values + "');", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable client = new DataTable();
                client.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                Console.WriteLine(values);
                return client;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(values);

                throw e;
            }
        }

        public DataTable insertEmployee(String values)//inserta los datos de los clientes en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT empleado VALUES ('" + values + "');", connection);//hacemos la query
                MySqlDataReader result = query.ExecuteReader();//la ejecutamos
                DataTable employee = new DataTable();
                employee.Load(result);//cargamos los datos
                connection.Close();//cerramos la conexion
                Console.WriteLine(values);
                return employee;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(values);

                throw e;
            }
        }


    }

}
