using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        DataTable employee = new DataTable();



        public String dniA = "";
        public String nombreA = "";
        public String apellidoA = "";
        public String direccionA = "";
        public String telefonoA = "";
        public String nacimientoA = "";
        public String value = "";

        public Employee()
        {
            InitializeComponent();

            dataGridView1.DataSource = connection.getAllEmployee();//carga todos los emledos en el datagrid del primar tab
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

            nacimiento = nacimiento.Remove(10);//elimina los ultimos caracteres del String
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
            nombreA = nombreA + nombreAñadir.Text;
            apellidoA = apellidoA + apellidoAñadir.Text;
            direccionA = direccionA + direccionAñadir.Text;
            telefonoA = telefonoA + telefonoAñadir.Text;
            dniA = dniA + dniAñadir.Text;

            if (nombreA != "" && apellidoA != "" && direccionA != "" && telefonoA != "" && dniA != "")//si no ahi ningun parametro vacio entra aqui
            {
                value = dniA + "', '" + nombreA + "', '" + apellidoA + "', '" + direccionA + "', '" + telefonoA + "', '" + nacimientoA;

                employee = connection.insertClient(value);

                nombreAñadir.Text = "";//pongo todos los valores como al principio para poder seguir añadiendo mas
                apellidoAñadir.Text = "";
                direccionAñadir.Text = "";
                telefonoAñadir.Text = "";
                dniAñadir.Text = "";

                dniA = "";
                nombreA = "";
                apellidoA = "";
                direccionA = "";
                telefonoA = "";
                nacimientoA = "";


                errorAñadir.Text = "Añadido el empleado.";
            }
            else
            {
                errorAñadir.Text = "Añada todos los parametros.";
            }
        }

        private void nacimientoAñadir_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoA = nacimientoA + nacimientoAñadir.SelectionRange.Start.ToString();//guardo la fecha
            nacimientoA = changeDay(nacimientoA);
        }
    }
}
