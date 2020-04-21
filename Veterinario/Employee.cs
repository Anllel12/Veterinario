using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

/*
 * Autor: Angel Esquins
 * 
 * En esta clase se observa los empleados que tenemos en la base de datos, tambien los podemos bucar y añadir en los diferentes Tabscontrol.
 * 
 */

namespace Veterinario
{
    public partial class Employee : Form
    {
        Connection connection = new Connection();

        DateTime thisDay = DateTime.Today;//esto me da el dia actual

        public String value = "";
        public String nacimientoA = "";
        
        Boolean auxiliar = false;

        public Employee()
        {
            InitializeComponent();

            dataGridEmployee.DataSource = connection.getAllEmployee();//carga todos los empledos en el datagrid del primar tab
        }

        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        public String changeDay(String nacimiento)//cambio el orden del año y del dia para poder introducirlos en la base de datos
        {
            String año = "";
            String dia = "";

            año = nacimiento.Substring(6);//guardo el año
            dia = nacimiento.Substring(0, 2);//guardo el dia

            nacimiento = nacimiento.Remove(6);//elimino el año y lo cambio por el dia
            nacimiento = nacimiento.Insert(6, dia);
            nacimiento = nacimiento.Remove(0, 2);//elimino el dia y lo cambio por el año
            nacimiento = nacimiento.Insert(0, año);

            return nacimiento;
        }

        private void añadir_Click(object sender, EventArgs e)
        {
            if (nombreAñadir.Text != "" && apellidoAñadir.Text != "" && direccionAñadir.Text != "" && telefonoAñadir.Text != "" && dniAñadir.Text != "" && usuarioAñadir.Text != "" && contraseñaAñadir.Text != "")//si no ahi ningun parametro vacio entra aqui
            {
                String password = contraseñaAñadir.Text;
                string hash = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
                value = dniAñadir.Text + "', '" + nombreAñadir.Text + "', '" + apellidoAñadir.Text + "', '" + direccionAñadir.Text + "', '" + telefonoAñadir.Text + "', '"+ usuarioAñadir.Text + "', '" + hash + "', '" + nacimientoA;

                String error = connection.insertEmployee(value);

                nombreAñadir.Text = "";//pongo todos los valores como al principio para poder seguir añadiendo mas
                apellidoAñadir.Text = "";
                direccionAñadir.Text = "";
                telefonoAñadir.Text = "";
                dniAñadir.Text = "";
                usuarioAñadir.Text = "";
                contraseñaAñadir.Text = "";
                

                nacimientoA = "";
                value = "";

                errorAñadir.Text = error;
            }
            else
            {
                errorAñadir.Text = "Añada todos los parametros.";
            }
        }

        private void nacimientoAñadir_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoA = nacimientoA + nacimientoAñadir.SelectionRange.Start.ToString("d");//guardo la fecha
            nacimientoA = changeDay(nacimientoA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home w = new Home();

            w.Show();
            this.Hide();
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSheet w = new DataSheet();

            w.nombre.Text = dataGridEmployee.Rows[e.RowIndex].Cells["nombre"].Value.ToString();//segun la columna donde pinche te pone el nombre del empleado
            w.apellido.Text = dataGridEmployee.Rows[e.RowIndex].Cells["apellido"].Value.ToString();//segun la columna donde pinche te pone el apellido del empleado
            w.direccion.Text = dataGridEmployee.Rows[e.RowIndex].Cells["direccion"].Value.ToString();//segun la columna donde pinche te pone el direccion del empleado
            w.telefono.Text = dataGridEmployee.Rows[e.RowIndex].Cells["telefono"].Value.ToString();//segun la columna donde pinche te pone el telefono del empleado
            w.dni.Text = dataGridEmployee.Rows[e.RowIndex].Cells["dni"].Value.ToString();//segun la columna donde pinche te pone el dni del empleado
            w.nacimiento.Text = dataGridEmployee.Rows[e.RowIndex].Cells["nacimiento"].Value.ToString();//segun la columna donde pinche te pone el nacimiento del empleado

            w.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (nombreBuscar.Text == "" && apellidoBuscar.Text == "" && direccionBuscar.Text == "" && telefonoBuscar.Text == "" && dniBuscar.Text == "")//si ahi algun parametro relleno entra aqui
            {
                errorBuscar.Text = "Añada algun parametro.";
            }
            else
            {
                if (nombreBuscar.Text != "")//creo la busqueda
                {
                    value = value + "nombre='" + nombreBuscar.Text + "'";
                }
                if(apellidoBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "apellido='" + apellidoBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND apellido='" + apellidoBuscar.Text + "'";
                    }
                }
                if (direccionBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "direccion='" + direccionBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND direccion='" + direccionBuscar.Text + "'";
                    }
                }
                if (telefonoBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "telefono='" + telefonoBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND telefono='" + telefonoBuscar.Text + "'";
                    }
                }
                if (dniBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "dni='" + dniBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND dni='" + dniBuscar.Text + "'";
                    }
                }
                if (nacimientoBuscar.SelectionRange.Start.ToString("d") != thisDay.ToString("d"))//compruebo el dia de nacimiento ya qe no tiene sentido que haya nacido hoy
                {
                    if (value == "")
                    {
                        value = value + "nacimiento='" + nacimientoA + "'";
                    }
                    else
                    {
                        value = value + " AND nacimiento='" + nacimientoA + "'";
                    }
                }

                dataGridEmployee.DataSource = connection.findEmployee(value);

                tabPage1.Show();

                nombreBuscar.Text = "";//pongo todos los valores como al principio para poder seguir añadiendo mas
                apellidoBuscar.Text = "";
                direccionBuscar.Text = "";
                telefonoBuscar.Text = "";
                dniBuscar.Text = "";

                value = "";
                nacimientoA = "";
            }
        }

        private void nacimientoBuscar_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoA = nacimientoA + nacimientoBuscar.SelectionRange.Start.ToString("d");//guardo la fecha
            nacimientoA = changeDay(nacimientoA);
        }
    }
}
