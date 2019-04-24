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
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, total;

            n1 = int.Parse(Cantidad.Text);
            n2 = int.Parse(Tanto.Text);

            total = n1 * n2;

            textBox4.ToString();

        }
    }
}
