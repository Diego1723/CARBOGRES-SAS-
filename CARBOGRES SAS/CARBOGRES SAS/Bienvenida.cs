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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro atras = new registro();
            atras.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio atras = new inicio();
            atras.Show();
            this.Hide();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
