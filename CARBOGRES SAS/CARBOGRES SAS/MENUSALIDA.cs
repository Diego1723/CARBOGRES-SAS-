using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARBOGRES_SAS
{
    public partial class MENUSALIDA : Form
    {
        public MENUSALIDA()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu atras = new Menu();
            atras.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RmaterialSAL atras = new RmaterialSAL ();
            atras.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editarSalida atras = new editarSalida();
            atras.Show();
            this.Hide();
        }
    }
}
