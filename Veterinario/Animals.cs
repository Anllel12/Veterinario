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

        DateTime thisDay = DateTime.Today;//esto me da el dia actual

        public int codigo = 0;

        public String value = "";
        public String nacimientoA = "";

        public Animals()
        {
            InitializeComponent();

            dataGridAnimals.DataSource = connection.getAllAnimals();//carga todos los animales en el datagrid del primer tab
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
            if (codigoBuscar.Text == "" && nombreBuscar.Text == "" && especieBuscar.Text == "" && razaBuscar.Text == "" && dniBuscar.Text == "" && sexoBuscar.Text == "")//si ahi algun parametro relleno entra aqui
            {
                MessageBox.Show("Añada algun parametro.");
            }
            else
            {
                if (codigoBuscar.Text != "")//creo la busqueda
                {
                    int codigo = Convert.ToInt32(codigoBuscar.Text);

                    value = value + "codigo='" + codigo + "'";
                }
                if (nombreBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "nombre='" + nombreBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND nombre='" + nombreBuscar.Text + "'";
                    }
                }
                if (especieBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "especie='" + especieBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND especie='" + especieBuscar.Text + "'";
                    }
                }
                if (razaBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "raza='" + razaBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND raza='" + razaBuscar.Text + "'";
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
                if (sexoBuscar.Text != "")
                {
                    if (value == "")
                    {
                        value = value + "sexo='" + sexoBuscar.Text + "'";
                    }
                    else
                    {
                        value = value + " AND sexo='" + sexoBuscar.Text + "'";
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

                dataGridAnimals.DataSource = connection.findAnimals(value);

                tabPage1.Show();

                nombreBuscar.Text = "";//pongo todos los valores como al principio para poder seguir buscando más
                codigoBuscar.Text = "";
                especieBuscar.Text = "";
                razaBuscar.Text = "";
                dniBuscar.Text = "";
                sexoBuscar.Text = "";

                value = "";
                nacimientoA = "";
            }
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
                value = "";

                error.Text =animals;
            }
            else
            {
                error.Text = "Añada todos los parametros.";
            }
        }

        public void nacimientoAñadir_DateSelected(object sender, DateRangeEventArgs e)
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

        private void dataGridAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSheetAnimals w = new DataSheetAnimals();
            
            w.codigo.Text = dataGridAnimals.Rows[e.RowIndex].Cells["codigo"].Value.ToString();//segun la columna donde pinche te pone el codigo del animal
            w.nombre.Text = dataGridAnimals.Rows[e.RowIndex].Cells["nombre"].Value.ToString();//segun la columna donde pinche te pone el nombre del animal           
            w.especie.Text = dataGridAnimals.Rows[e.RowIndex].Cells["especie"].Value.ToString();//segun la columna donde pinche te pone el especie del animal
            w.raza.Text = dataGridAnimals.Rows[e.RowIndex].Cells["raza"].Value.ToString();//segun la columna donde pinche te pone el raza del animal
            w.dni.Text = dataGridAnimals.Rows[e.RowIndex].Cells["dueño"].Value.ToString();//segun la columna donde pinche te pone el dueño del animal
            w.sexo.Text = dataGridAnimals.Rows[e.RowIndex].Cells["sexo"].Value.ToString();//segun la columna donde pinche te pone el sexo del animal
            w.nacimiento.Text = dataGridAnimals.Rows[e.RowIndex].Cells["nacimiento"].Value.ToString();//segun la columna donde pinche te pone el nacimiento del animal

            w.Show();
        }

        private void nacimientoBuscar_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoA = nacimientoA + nacimientoBuscar.SelectionRange.Start.ToString("d");//guardo la fecha
            nacimientoA = changeDay(nacimientoA);
        }
    }
}
