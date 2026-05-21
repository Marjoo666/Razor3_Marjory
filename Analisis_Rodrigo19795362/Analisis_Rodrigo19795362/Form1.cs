using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Rodrigo19795362
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form2 ventanaProductos = new Form2();
            ventanaProductos.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form3 ventanaEmpleados = new Form3();
            ventanaEmpleados.Show();
            this.Hide();
        }
    }
}
