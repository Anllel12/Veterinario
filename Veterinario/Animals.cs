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
 * En esta clase se puede observar todos los animales que tenemos en la base de datos 
 * y tambien podemos añadir más animales o buscarlos.
 * 
 */

namespace Veterinario
{
    public partial class Animals : Form
    {
        Connection connection = new Connection();
        DataTable animals = new DataTable();

        public int codigo = 0;

        public String value = "";
        public String nacimientoA = "";

        public Animals()
        {
            InitializeComponent();

            dataGridView1.DataSource = connection.getAllAnimals();//carga todos los animales en el datagrid del primer tab
            animals = connection.getAllAnimals();
            codigo = Convert.ToInt32(animals.Rows[0]["codigo"]);//hago que coincida el ultimo codigo que ahi en la base de datos con el codigo
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
            dia = nacimiento.Substring(0,2);//guardo el dia

            nacimiento = nacimiento.Remove(6);//elimino el año y lo cambio por el dia
            nacimiento = nacimiento.Insert(6, dia);
            nacimiento = nacimiento.Remove(0, 2);//elimino el dia y lo cambio por el año
            nacimiento = nacimiento.Insert(0, año);
            
            return nacimiento;
        }

        public void buscar_Click(object sender, EventArgs e)
        {

        }

        public void añadir_Click(object sender, EventArgs e)
        {
            if (nombreAñadir.Text != "" && razaAñadir.Text != "" && especieAñadir.Text != "" && sexoAñadir.Text != "" && dniAñadir.Text != "")//si no ahi ningun parametro vacio entra aqui
            {
                codigo++;

                value = codigo + ", '" + nombreAñadir.Text + "', '" + nacimientoAñadir.Text + "', '" + razaAñadir.Text + "', '" + dniAñadir.Text + "', '" + especieAñadir.Text + "', '" + sexoAñadir.Text;
                
                String animals = connection.insertAnimal(value);

                nombreAñadir.Text = "";//pongo todos los valores como al principio para poder seguir añadiendo mas
                razaAñadir.Text = "";
                especieAñadir.Text = "";
                sexoAñadir.Text = "";
                dniAñadir.Text = "";

                nacimientoA = "";

                error.Text =animals;
            }
            else
            {
                error.Text = "Añada todos los parametros.";
            }
        }

        public void nacimientoAñadir_DateSelected(object sender, DateRangeEventArgs e)
        {           
            nacimientoA = nacimientoA + nacimientoAñadir.SelectionRange.Start.ToString();//guardo la fecha
            nacimientoA = changeDay(nacimientoA);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Home w = new Home();

            w.Show();
            this.Hide();
        }
    }
}
