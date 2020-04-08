using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Animals : Form
    {
        Connection connection = new Connection();

        int codigo = 5;

        String nombreA = "";
        String razaA = "";
        String especieA = "";
        String sexoA = "";
        String dniA = "";

        public Animals()
        {
            InitializeComponent();

            dataGridView1.DataSource = connection.getAllAnimals();
        }

        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void añadir_Click(object sender, EventArgs e)
        {

        }
    }
}
