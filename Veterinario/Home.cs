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
 * En esta clase se puede observar la pantalla principal de la aplicacion.
 * 
 */

namespace Veterinario
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals window = new Animals();

            window.Show();

            this.Hide();
        }

       
    }
}
