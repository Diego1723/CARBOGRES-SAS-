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
    public partial class MMaterial : Form
    {
        public MMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroMaterial atras = new RegistroMaterial ();
            atras.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu atras = new Menu();
            atras.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUSCARM atras = new BUSCARM ();
            atras.Show();
            this.Hide();
        }
    }
}
