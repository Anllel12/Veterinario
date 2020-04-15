﻿using System;
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
 * En esta clase se observa los clientes que tenemos en la base de datos, tambien los podemos bucar y añadir en los diferentes Tabscontrol.
 * 
 */

namespace Veterinario
{
    public partial class Clients : Form
    {
        Connection connection = new Connection();

        public String nacimientoA = "";
        public String value = "";


        public Clients()
        {
            InitializeComponent();

            dataGridClients.DataSource = connection.getAllClients();//carga todos los clientes en el datagrid del primar tab
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
            if (nombreAñadir.Text != "" && apellidoAñadir.Text != "" && direccionAñadir.Text != "" && telefonoAñadir.Text != "" && dniAñadir.Text != "")//si no ahi ningun parametro vacio entra aqui
            {
                value = dniAñadir.Text + "', '" + nombreAñadir.Text + "', '" + apellidoAñadir.Text + "', '" + direccionAñadir.Text + "', '" + telefonoAñadir.Text + "', '" + nacimientoA;

                String client = connection.insertClient(value);

                nombreAñadir.Text = "";//pongo todos los valores como al principio para poder seguir añadiendo mas
                apellidoAñadir.Text = "";
                direccionAñadir.Text = "";
                telefonoAñadir.Text = "";
                dniAñadir.Text = "";

                nacimientoA = "";
                

                errorAñadir.Text = client;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Home w = new Home();

            w.Show();
            this.Hide();
        }

        private void dataGridClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSheet w = new DataSheet();

            w.nombre.Text = dataGridClients.Rows[e.RowIndex].Cells["nombre"].Value.ToString();//segun la columna donde pinche te pone el nombre del cliente
            w.apellido.Text = dataGridClients.Rows[e.RowIndex].Cells["apellido"].Value.ToString();//segun la columna donde pinche te pone el apellido del cliente
            w.direccion.Text = dataGridClients.Rows[e.RowIndex].Cells["direccion"].Value.ToString();//segun la columna donde pinche te pone el direccion del cliente
            w.telefono.Text = dataGridClients.Rows[e.RowIndex].Cells["telefono"].Value.ToString();//segun la columna donde pinche te pone el telefono del cliente
            w.dni.Text = dataGridClients.Rows[e.RowIndex].Cells["dni"].Value.ToString();//segun la columna donde pinche te pone el dni del cliente
            w.nacimiento.Text = dataGridClients.Rows[e.RowIndex].Cells["nacimiento"].Value.ToString();//segun la columna donde pinche te pone el nacimiento del cliente

            w.Show();
        }
    }
}
