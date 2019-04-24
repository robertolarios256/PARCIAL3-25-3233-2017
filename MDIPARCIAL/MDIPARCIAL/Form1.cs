using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datosDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos Ejercicio1 = new Datos();
            Ejercicio1.MdiParent = this;
            Ejercicio1.Show();
            
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones Ejercicio2 = new Operaciones();
            Ejercicio2.MdiParent = this;
            Ejercicio2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
