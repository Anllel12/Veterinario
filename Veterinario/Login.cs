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
 * En esta clase se muestra el inicio de sesion antes de entrar a la aplicacion.
 * 
 */

namespace Veterinario
{
    public partial class Login : Form
    {
        Connection connection = new Connection();
        DataTable employee = new DataTable();

        String user = "";
        String password = "";

        public Login()
        {
            InitializeComponent();
        }    

        private void entrar_Click(object sender, EventArgs e)
        {
            user = user + usuario.Text;
            password = password + contraseña.Text;

            employee = connection.getUserPassword();

            //for (int i = 0; i < employee.Rows.Count; i++)
            //{
            //    if (user.Equals(employee.Rows[i]["usuario"].ToString()) && password.Equals(employee.Rows[i]["contraseña"].ToString()))//comparo lo introducido en los TextBox con la base de datos
            //    {
            //        Home window = new Home();

            //        window.Show();

            //        this.Hide();
            //    }/*-+
            //    else .
            //    {
            //        user = "";//pongo todos los String vacios
            //        password = "";
            //        usuario.Text = "";
            //        contraseña.Text = "";

            //        label3.Text = "Error al introducir el usuario o la contraseña. Vuelva a intentarlo.";
            //    }               
            //}
            Home window = new Home();

            window.Show();

            this.Hide();
        }
    }
}
