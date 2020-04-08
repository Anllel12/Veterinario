using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{

    class Connection
    {
        public MySqlConnection connection;

        public Connection()
        {
            try
            {
                connection = new MySqlConnection("Server=127.0.0.1; Database=veterinario; Uid=root; Pwd=; Port=3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getUserPassword()
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


    }

}
