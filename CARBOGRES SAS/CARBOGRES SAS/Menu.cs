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
    public partial class Menu : Form
    {
        private Timer ti; 
        public Menu()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            ti.Enabled = true ;
            InitializeComponent();

        }

        private void eventoTimer(object ob , EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            label3.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bienvenida atras = new Bienvenida();
            atras.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registroPersonal atras = new registroPersonal();
            atras.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MMaterial atras = new MMaterial();
            atras.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MENUSALIDA atras = new MENUSALIDA();
            atras.Show();
            this.Hide();
        }
    }
}
