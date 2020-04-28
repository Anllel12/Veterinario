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

        public Login()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

            if (connection.getUserPassword(usuario.Text, contraseña.Text))
            {
                Home window = new Home();

                window.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Usuario o contraseña incorrectos";

                usuario.Text = "";
                contraseña.Text = "";
            }
        }
    }
}
