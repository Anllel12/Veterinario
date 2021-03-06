﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;

/*
 * Autor: Angel Esquinas
 * 
 * En esta clase observamos todas los metodos que utilizamos para conectarnos con la base de datos.
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

        public Boolean getUserPassword(String usuario, String contraseña)//obtiene el usuario y contraseña
        {
            try
            {
                connection.Open();//conectamos con la base de datos

                MySqlCommand query = new MySqlCommand("SELECT * FROM empleado WHERE usuario = @usuario" , connection);//hacemos la query
                query.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader result = query.ExecuteReader();//la ejecutamos

                if (result.Read())
                {
                    String passwordHash = result.GetString("contraseña");//mira la contraseña que ahi en la base de datos con el Hash
                    if(BCrypt.Net.BCrypt.Verify(contraseña, passwordHash))//comprueba que sean las misma 
                    {
                        connection.Close();//cerramos la conexion
                        return true;
                    }
                    connection.Close();//cerramos la conexion
                    return false;
                }

                connection.Close();//cerramos la conexion
                return false;
            }
            catch (MySqlException e)
            {
                return false;
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

        public DataTable getAllEmployee()//obtiene todos los empleados
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT dni, nombre, apellido, direccion, telefono, nacimiento FROM empleado", connection);//hacemos la query
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

        public String insertAnimal(String values)//inserta los datos de los animales en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT animales VALUES ('" + values + "');", connection);//hacemos la query

                query.ExecuteNonQuery();

                connection.Close();//cerramos la conexion
                return "Añadido correctamente";
            }
            catch (MySqlException e)
            {
                Clients w = new Clients();
                Animals wi = new Animals();

                w.Show();
                wi.Hide();
                w.errorAñadir.Text = "Añada primero el cliente a la base de datos.";
                w.dniAñadir.Text = wi.dniAñadir.Text;
                
                return "Error al añadirlo";
            }
        }

        public String insertClient(String values)//inserta los datos de los clientes en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT cliente VALUES ('" + values + "');", connection);//hacemos la query

                query.ExecuteNonQuery();
                connection.Close();//cerramos la conexion
                return "Añadido correctamente";

            }
            catch (MySqlException e)
            {
                return "Error al añadirlo";
            }
        }

        public String insertEmployee(String values)//inserta los datos de los clientes en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("INSERT empleado VALUES ('" + values + "');", connection);//hacemos la query

                query.ExecuteNonQuery();
                connection.Close();//cerramos la conexion
                return "Añadido correctamente";
            }
            catch (MySqlException e)
            {
                return "Error al añadirlo";
            }
        }

        public DataTable findEmployee(String values)//busca los datos de los empleados en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM empleado WHERE " + values, connection);//hacemos la query
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

        public DataTable findClient(String values)//busca los datos de los clientes en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM cliente WHERE " + values, connection);//hacemos la query
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

        public DataTable findAnimals(String values)//busca los datos de los animales en la base de datos
        {
            try
            {
                connection.Open();//conectamos con la base de datos
                MySqlCommand query = new MySqlCommand("SELECT * FROM animales WHERE " + values, connection);//hacemos la query
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


    }

}
